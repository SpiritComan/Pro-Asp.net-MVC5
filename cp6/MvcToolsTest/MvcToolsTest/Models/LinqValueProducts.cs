using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcToolsTest.Models
{
    public class LinqValueProducts:IValueCalculate
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}