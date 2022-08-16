using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsStorageHost
{
    public class DocumentsData
    {
        public bool Success;
        public string ErrorMessage;

        public List<DocumentData> documentDatas = new List<DocumentData>();
    }

    public class DocumentData
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ActualizationDate { get; set; }
    }
}
