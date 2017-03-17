using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopTest.Models
{
    public static class MeExtensionMethods
    {
        public static decimal TotalPrice(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (var pro in cartParam.ProductArray)
            {
                total += pro.Price;
            }

            return total;
        }
    }
}