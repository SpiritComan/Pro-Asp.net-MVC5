using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcToolsTest.Models
{
    public class LinqValueCalulator:IValueCalculate
    {
        private IDiscountHelper discounter;

        public LinqValueCalulator(IDiscountHelper dicountParam)
        {
            discounter = dicountParam;
        }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}