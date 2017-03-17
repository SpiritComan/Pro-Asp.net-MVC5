using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorTest.Models;

namespace RazorTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public ActionResult Index()
        {
            var newProduct = new Product()
            {
                Category = "Soccer",
                Description = "Soccer",
                Price = 200M,
                ProductID = 100,
                ProductName = "Kayam"
            };
            return View(newProduct);
        }

        public ActionResult RazorTest()
        {
            var proArrays = new Product[]
            {
                new Product()
                {
                    Category = "Soccer",
                    Description = "Soccer",
                    Price = 200M,
                    ProductID = 100,
                    ProductName = "Kayam"
                },
                new Product()
                {
                    Category = "Soccer",
                    Description = "Soccer",
                    Price = 100M,
                    ProductID = 101,
                    ProductName = "Addas"
                }
            };

            return View(proArrays);
        }
    }
}