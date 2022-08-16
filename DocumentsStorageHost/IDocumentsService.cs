using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DocumentsStorageHost
{
    [ServiceContract]
    public interface IDocumentsService
    {
        [OperationContract]
        DocumentsData GetData();
    }
}
