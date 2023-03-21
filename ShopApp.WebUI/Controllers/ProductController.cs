using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new Product { Name = "asd", Price = 3244, Description = "asdf" };

            //ViewData["Category"] = "Telefonlar";
            //ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            //ViewBag.Product = product;

            return View(product);
        }
        public IActionResult List()
        {
            var products = new List<Product>()
            {
                new Product {Name="Iphone 8", Price=3000, Description="Telefon"},
                new Product {Name="Iphone X", Price=6000, Description="Telefon"},
            };

            var category = new Category() { Name = "Telefonlar", Description = "Telefon kategorisi" };

            ViewBag.Category = category;

            return View(products);
        }

        public IActionResult Details(int id)
        {
            //ViewBag.Name = "samsung s6";
            //ViewBag.Price = 3000;
            //ViewBag.Description = "iyi telefon";

            var product = new Product();
            product.Name = "samsung s6";
            product.Price = 3000;
            product.Description = "iyi telefon";

            return View(product);
        }
    }
}
