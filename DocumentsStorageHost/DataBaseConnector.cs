using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsStorageHost
{
    public class DataBaseConnector : IDisposable
    {
        private string documentsDB;
        private string documentsTable;
        private SqlConnection connection;
        private DataBaseConnectionData dataBaseConnectionData;

        public DataBaseConnector(DataBaseConnectionData data)
        {
            dataBaseConnectionData = data;
            SetDBAndTableFromData(dataBaseConnectionData);
        }

        public void OpenConnectionToDB()
        {
            connection = new SqlConnection(GetConnectionString(dataBaseConnectionData));
            connection.Open();
        }

        public void PrepareDBToWork()
        {
            ExecuteSQLCommand(connection, String.Format("IF NOT EXISTS (SELECT name FROM master.sys.databases WHERE name = N'{0}') \r CREATE DATABASE {0}", documentsDB));
            ExecuteSQLCommand(connection, String.Format("USE {0}; IF OBJECT_ID(N'{1}', N'U') IS NULL BEGIN CREATE TABLE {1} (ID INT not null, Name NVARCHAR(50) not null, CreatedDate DATE not null, ActualizationDate DATE not null); END;", documentsDB, documentsTable));
        }

        public DocumentsData GetAllDocuments()
        {
            var stringCommand = String.Format("USE {0} SELECT Id, Name, CreatedDate, ActualizationDate FROM {1}", documentsDB, documentsTable);
            var result = new DocumentsData();

            using (SqlCommand command = new SqlCommand(stringCommand, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var documentData = new DocumentData();
                        documentData.Id = reader.GetInt32(0);
                        documentData.Name = reader.GetString(1);
                        documentData.CreatedDate = reader.GetDateTime(2);
                        documentData.ActualizationDate = reader.GetDateTime(3);
                        result.documentDatas.Add(documentData);
                    }
                }
            }

            return result;
        }

        private void ExecuteSQLCommand(SqlConnection connection, string stringCommand)
        {
            using (SqlCommand command = new SqlCommand(stringCommand, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }
                }
            }
        }

        private void SetDBAndTableFromData(DataBaseConnectionData data)
        {
            documentsDB = data.DocumentsDatabase;
            documentsTable = data.DocumentsTable;
        }

        private string GetConnectionString(DataBaseConnectionData data)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = data.DataSource;

            if (!data.TrustedConnection)
            {
                builder.UserID = data.UserId;
                builder.Password = data.UserPassword;
            }
            else
                builder.Add("Trusted_Connection", "true");

            return builder.ConnectionString;
        }

        public void Dispose()
        {
            connection?.Dispose();
        }
    }
}
