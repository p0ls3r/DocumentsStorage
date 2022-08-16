using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsStorageHost
{
    public class DocumentsServiceHost : ServiceHost
    {
        public DocumentsServiceHost(DataBaseConnector connector, Type serviceType, params Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        {
            if (connector == null)
            {
                throw new ArgumentNullException("No connection data provided");
            }

            foreach (var cd in this.ImplementedContracts.Values)
            {
                cd.Behaviors.Add(new InstanceProviderWithParam(connector));
            }
        }
    }
}
