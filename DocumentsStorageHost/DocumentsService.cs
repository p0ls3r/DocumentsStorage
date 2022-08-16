using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading;

namespace DocumentsStorageHost
{
    public class DocumentsService : IDocumentsService
    {
        private DataBaseConnector DBConnectionData;

        public DocumentsData GetData()
        {
            try
            {
                var data = DBConnectionData?.GetAllDocuments();

                if (data != null && data.documentDatas.Count > 0)
                {
                    data.Success = true;
                    return data;
                }
                else
                {
                    data.Success = false;

                    if (data == null)
                        data.ErrorMessage = "Error occured during service work, please contact your system administrator";
                    else
                        if (data.documentDatas.Count == 0)
                        data.ErrorMessage = "Data base does not contain any contracts";

                    return data;
                }
            }
            catch
            {
                var data = new DocumentsData();
                data.ErrorMessage = "Error occured during service work, please contact your system administrator";
                return data;
            }

        }

        public DocumentsService()
        {

        }

        public DocumentsService(DataBaseConnector test)
        {
            DBConnectionData = test;
        }
    }
}