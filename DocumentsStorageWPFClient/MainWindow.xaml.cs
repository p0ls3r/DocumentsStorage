using DocumentsStorageWPFClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DocumentsStorageWPFClient
{
    public partial class MainWindow : Window
    {
        private DocumentsServiceClient client = new DocumentsServiceClient();
        public MainWindow()
        {
            InitializeComponent();
            SetConnectionString();
            SetMessage("Press the button \"Get Contracts\" to get started ");
        }


        private void SetConnectionString()
        {
            ConnectionAdressField.Text = client.Endpoint.Address.Uri.AbsoluteUri;
        }

        private async void ConnectionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConnectionButton.IsEnabled = false;
                var connectionUri = ConnectionAdressField.Text;
                var documentsData = await Task.Run(() => GetDocumentsData(connectionUri));

                HandleContractsData(documentsData);
                ConnectionButton.IsEnabled = true;
            }
            catch (Exception ex)
            {
                SetMessage(String.Format("An error has occurred: {0}", ex.Message));
                ConnectionButton.IsEnabled = true;
            }
        }

        private void HandleContractsData(DocumentsData data)
        {
            if (data.Success)
            {
                DocumentsGrid.ItemsSource = data.documentDatas.Select(d => new LocalDocumentData(d));
                SetMessage("Successful receipt of the list of contracts ");
            }
            else
            {
                SetMessage(data.ErrorMessage);
            }
        }

        private DocumentsData GetDocumentsData(string connectionUri)
        {
            client = new DocumentsServiceClient();

            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(connectionUri);

            var documentsData = client.GetData();
            client.Close();

            return documentsData;
        }

        private void SetMessage(string message)
        {
            MessageBox.Text = message;
        }
    }
}
