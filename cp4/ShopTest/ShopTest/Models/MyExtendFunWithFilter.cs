using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopTest.Models
{
    public static class MyExtendFunWithFilter
    {
        public static decimal TotalPrice(this IEnumerable<Products> productParam)
        {
            decimal totalPrice = 0M;

            foreach (var productse in productParam)
            {
                totalPrice += productse.Price;
            }

            return totalPrice;
        }

        public static IEnumerable<Products> FileterByCategory(this IEnumerable<Products> productParam,
            String categoryParam)
        {
            foreach (var productse in productParam)
            {
                if (productse.Category == categoryParam)
                {
                    yield return productse;
                }
            }
        }
    }
}