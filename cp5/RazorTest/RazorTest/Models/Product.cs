using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorTest.Models
{
    public class Product
    {
        public int ProductID { set; get; }

        public String ProductName { set; get; }

        public String Description { set; get; }

        public String Category { set; get; }

        public decimal Price { set; get; }
    }
}