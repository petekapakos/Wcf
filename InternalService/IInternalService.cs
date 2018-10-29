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
    [ServiceContract]
    public interface IInternalService
    {
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
    
}
