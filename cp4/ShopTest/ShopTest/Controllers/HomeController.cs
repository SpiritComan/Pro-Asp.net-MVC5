using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopTest.Models;

namespace ShopTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public String Index()
        {
            return "Navigate to a url to Show an example";
        }

        public ViewResult AutoProperty()
        {
            var myProduct = new Products()
            {
                Category = "WaterSports",
                Description = "A boat for one persion",
                ProductId = 100,
                Price = 1000M,
                ProductName = "Kayak"
            };

            return View("Result", (object) String.Format("Category:{0}", myProduct.Category));
        }

        public ViewResult UseExtension()
        {
            var cart =new ShoppingCart()
            {
                ProductArray = new List<Products>()
                {
                    new Products(){ProductName = "Kayak",Price = 275M},
                    new Products(){ProductName = "LifeJacket",Price = 48.96M},
                    new Products(){ProductName = "Soccer ball",Price = 19.50M},
                    new Products(){ProductName = "Corner flag",Price = 34.95M}
                }
            };

            decimal cartTotal = cart.TotalPrice();

            return View("Result", (object) String.Format("Total{0}", cartTotal));
        }

        public ViewResult UseEnumExtension()
        {
            IEnumerable<Products> products = new ShoppingCart()
            {
                ProductArray = new List<Products>()
                {
                    new Products(){ProductName = "Kayak",Price = 275M},
                    new Products(){ProductName = "LifeJacket",Price = 48.96M},
                    new Products(){ProductName = "Soccer ball",Price = 19.50M},
                    new Products(){ProductName = "Corner flag",Price = 34.95M}
                }
            };

            Products[] productses =
            {
                 new Products(){ProductName = "Kayak",Price = 275M},
                    new Products(){ProductName = "LifeJacket",Price = 45.96M},
                    new Products(){ProductName = "Soccer ball",Price = 12.50M},
                    new Products(){ProductName = "Corner flag",Price = 32.95M}
            };

            decimal totalPrice = products.TotalPrices();

            decimal arrayPrice = productses.TotalPrices();


            return View("Result", (object) String.Format("EnumPrice {0},ArrayPrice {1}", totalPrice, arrayPrice));
        }

        public ViewResult UserFilterExtensionFun()
        {
            IEnumerable<Products> products = new ShoppingCart()
            {
                ProductArray = new List<Products>()
                {
                    new Products(){ProductName = "Kayak",Price = 275M,Category = "Watersports"},
                    new Products(){ProductName = "LifeJacket",Price = 48.96M,Category = "Watersports"},
                    new Products(){ProductName = "Soccer ball",Price = 19.50M,Category = "Soccer"},
                    new Products(){ProductName = "Corner flag",Price = 34.95M,Category = "Soccer"}
                }
            };

            decimal totalPrice = 0;
            foreach (var productse in products.FileterByCategory("Soccer"))
            {
                totalPrice += productse.Price;
            }

            return View("Result", (object) String.Format("TotalPrice {0}", totalPrice));
        }

        public ViewResult LamadaExtendFun()
        {
            IEnumerable<Products> products = new ShoppingCart()
            {
                ProductArray = new List<Products>()
                {
                    new Products(){ProductName = "Kayak",Price = 275M,Category = "Watersports"},
                    new Products(){ProductName = "LifeJacket",Price = 48.96M,Category = "Watersports"},
                    new Products(){ProductName = "Soccer ball",Price = 19.50M,Category = "Soccer"},
                    new Products(){ProductName = "Corner flag",Price = 34.95M,Category = "Soccer"}
                }
            };

            Func<Products, bool> selector = prod => (prod.Category == "Soccer");

            decimal totalPrice =0;
            foreach (var pro in products.Filter(selector))
            {
                totalPrice += pro.Price;
            }

            return View("Result", (object) String.Format("Total:{0}", totalPrice));
        }
    }
}