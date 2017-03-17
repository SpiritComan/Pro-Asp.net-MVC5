using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopTest.Models
{
    public static class MyEnumExtendsWithLamadaMethod
    {
        public static decimal TotalPrice(this IEnumerable<Products> proParas)
        {
            decimal totalPrice = 0;
            foreach (var productse in proParas)
            {
                totalPrice += productse.Price;
            }

            return totalPrice;
        }

        public static IEnumerable<Products> FileByCagetory(this IEnumerable<Products> proParas, string category)
        {
            foreach (var productse in proParas)
            {
                if (productse.Category == category)
                    yield return productse;
            }

        }

        public static IEnumerable<Products> Filter(this IEnumerable<Products> proParas, Func<Products, bool> selector)
        {
            foreach (var productse in proParas)
            {
                if (selector(productse))
                    yield return productse;
            }
            {
                
            }
        }
    }
}