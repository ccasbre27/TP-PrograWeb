using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    [ServiceContract]
    public interface IProducts
    {
        [OperationContract]
        bool UpdatePrice(string code, decimal price);
    }
}
