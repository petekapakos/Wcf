using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using InternalService.Services.External;

namespace InternalService
{
    public class InternalService : IInternalService
    {
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            using (var service = new Service1Client())
                return service.GetDataUsingDataContract(composite);
        }
    }
}
