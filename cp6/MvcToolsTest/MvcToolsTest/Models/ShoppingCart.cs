using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcToolsTest.Models
{
    public class ShoppingCart
    {
        private IValueCalculate calc;

        public ShoppingCart(IValueCalculate calcParam)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> Products { set; get; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}