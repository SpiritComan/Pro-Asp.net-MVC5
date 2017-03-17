using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopTest.Models
{
    public static class MyEnumExtendsionnMethod
    {
        public static decimal TotalPrices(this IEnumerable<Products> productParas)
        {
            decimal totalPrice =0;

            foreach (var productPara in productParas)
            {
                totalPrice += productPara.Price;
            }

            return totalPrice;
        }
    }
}