using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopTest.Models
{
    public class Products
    {
        public int ProductId { set; get; }

        public String ProductName { set; get; }

        public String Description { set; get; }

        public decimal Price { set; get; }

        public String Category { set; get; }
    }
}