using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace DocumentsStorageHost
{
    public static class ConfigurationFileHandler
    {
        private static string ConfigurationFileName = @"DocumentsStorage.cfg";

        public static DataBaseConnectionData ReadDBConnectionData()
        {
            DataBaseConnectionData data;

            var deSerializer = new Deserializer();

            if (!File.Exists(ConfigurationFileName))
                return CreateNewData();

            FileInfo cfgFileInfo = new FileInfo(ConfigurationFileName);

            using (var strRdr = new StreamReader(cfgFileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                data = deSerializer.Deserialize<DataBaseConnectionData>(strRdr);
            }

            if (data == null)
                data = CreateNewData();

            return data;
        }

        public static void SaveDBConnectionData(DataBaseConnectionData data)
        {
            if (File.Exists("DocumentsStorage.cfg"))
                File.Delete("DocumentsStorage.cfg");

            var serializer = new Serializer();

            using (TextWriter writer = File.CreateText("DocumentsStorage.cfg"))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static DataBaseConnectionData CreateNewData()
        {
            var data = new DataBaseConnectionData();
            data.DataSource = @"localhost\SQLEXPRESS";
            data.TrustedConnection = true;
            data.DocumentsDatabase = "documentsDB";
            data.DocumentsTable = "dbo.documentsTable";

            return data;
        }
    }

    public class DataBaseConnectionData
    {
        public string DataSource {get; set;}
        public string UserId { get; set; }
        public string UserPassword { get; set; }
        public bool TrustedConnection { get; set; }

        public string DocumentsDatabase { get; set; }
        public string DocumentsTable { get; set; }
    }
}
