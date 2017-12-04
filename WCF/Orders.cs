using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    public class Orders : BaseService, IOrders
    {
        public decimal GetPrice(string code, decimal quantity)
        {
            Product product = products.Where(e => e.Code == code).FirstOrDefault();
            decimal price = 0;

            if (product != null)
            {
                price = product.Price * quantity;
            }

            return price;
        }

 
    }
}
