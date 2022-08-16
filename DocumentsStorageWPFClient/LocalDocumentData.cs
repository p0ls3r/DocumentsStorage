using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentsStorageWPFClient.ServiceReference1;

namespace DocumentsStorageWPFClient
{
    class LocalDocumentData : DocumentData
    {
        public bool Actual { get; set; }

        public LocalDocumentData(DocumentData documentData)
        {
            this.ActualizationDate = documentData.ActualizationDate;
            this.CreatedDate = documentData.CreatedDate;
            this.Name = documentData.Name;
            this.Id = documentData.Id;

            Actual = (DateTime.Today - this.ActualizationDate).TotalDays < 60;
        }
    }
}