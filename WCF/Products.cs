using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    public class Products : BaseService, IProducts
    {
        public bool UpdatePrice(string code, decimal price)
        {
            Product product = products.Where(e => e.Code == code).FirstOrDefault();
            bool result = false;

            if (product != null)
            {
                product.Price = price;
                result = true;
            }

            return result;
        }
    }
}
