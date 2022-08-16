using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DocumentsStorageHost
{
    public partial class MainWindow : Window
    {
        private DocumentsServiceHost selfHost;
        private DataBaseConnectionData dataBaseConnectionData;
        private DataBaseConnector dbConnector;

        public MainWindow()
        {
            InitializeComponent();
            this.Closing += StopHost;
            ReadDataFromCfgFile();
            FillWindowFieldsFromData();
            UpdateUserIDAvailability();
        }

        private void ReadDataFromCfgFile()
        {
            dataBaseConnectionData = ConfigurationFileHandler.ReadDBConnectionData();
        }

        private void FillWindowFieldsFromData()
        {
            DataSourceField.Text = dataBaseConnectionData.DataSource;
            DataBaseField.Text = dataBaseConnectionData.DocumentsDatabase;
            DataTableField.Text = dataBaseConnectionData.DocumentsTable;
            UserIDField.Text = dataBaseConnectionData.UserId;
            UserPasswordField.Text = dataBaseConnectionData.UserPassword;
            TrustedConnectionBox.IsChecked = dataBaseConnectionData.TrustedConnection;
        }

        private void StopHost(object sender, System.ComponentModel.CancelEventArgs e)
        {
            selfHost?.Close();
        }

        private void StartHost()
        {
            selfHost = new DocumentsServiceHost(dbConnector, typeof(DocumentsService));

            try
            {
                selfHost.AddServiceEndpoint(typeof(IDocumentsService), new WSHttpBinding(), "DocumentsService");
                selfHost.Open();
                AddMessage("Service host started!");
            }
            catch (CommunicationException ce)
            {
                AddMessage("Service host start aborted: " + ce.Message);
                selfHost.Abort();
            }
        }

        private bool CanConnectToDB()
        {
            try
            {
                dbConnector = new DataBaseConnector(dataBaseConnectionData);
                dbConnector.OpenConnectionToDB();
                dbConnector.PrepareDBToWork();
                AddMessage("Successful connection to DB");
                return true;
            }
            catch (SqlException e)
            {
                AddMessage("Cannot connect to DB: " + e.Message);
                return false;
            }
        }

        private void UpdateDBConnectionData()
        {
            dataBaseConnectionData.DataSource = DataSourceField.Text;
            dataBaseConnectionData.DocumentsDatabase = DataBaseField.Text;
            dataBaseConnectionData.DocumentsTable = DataTableField.Text;
            dataBaseConnectionData.UserId = UserIDField.Text;
            dataBaseConnectionData.UserPassword = UserPasswordField.Text;
            dataBaseConnectionData.TrustedConnection = TrustedConnectionBox.IsChecked.Value;

            ConfigurationFileHandler.SaveDBConnectionData(dataBaseConnectionData);
        }

        private void AddMessage(string message)
        {
            MessagesBox.Items.Add(String.Format("{0:t} {1}", DateTime.Now, message));
        }

        private void StartHost_Click(object sender, RoutedEventArgs e)
        {
            UpdateDBConnectionData();
            if (CanConnectToDB())
            {
                StartHost();
                StartHostButton.IsEnabled = false;
            }
        }

        private void TrustedConnectionBox_Click(object sender, RoutedEventArgs e)
        {
            UpdateUserIDAvailability();
        }

        private void UpdateUserIDAvailability()
        {
            if (TrustedConnectionBox.IsChecked.HasValue && TrustedConnectionBox.IsChecked.Value)
            {
                UserIDField.IsEnabled = false;
                UserPasswordField.IsEnabled = false;
            }
            else
            {
                UserIDField.IsEnabled = true;
                UserPasswordField.IsEnabled = true;
            }
        }
    }
}
