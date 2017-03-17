using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopTest.Models
{
    public class ShoppingCart:IEnumerable<Products>
    {
        public List<Products> ProductArray { set; get; }
        public IEnumerator<Products> GetEnumerator()
        {
            return ProductArray.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}