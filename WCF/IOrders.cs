using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    [ServiceContract]
    public interface IOrders
    {
        [OperationContract]
        decimal GetPrice(string code, decimal quantity);
      
    }
    
}
