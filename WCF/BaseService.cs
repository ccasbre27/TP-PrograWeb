using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public class BaseService
    {
        public static List<Product> products = new List<Product>()
        {
            new Product("Pez", "pezuña", 2000),
            new Product("Cos", "costilla", 3500),
            new Product("Toc", "tocino", 1000),
            new Product("Lom", "lomo", 8000)
        };
    }
}
