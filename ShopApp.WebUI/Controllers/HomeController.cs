using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product {Name="Iphone 7", Price=3000, Description="Telefon", IsApproved = false},
                new Product {Name="Iphone 8", Price=6000, Description="Telefon", IsApproved = true},
                new Product {Name="Iphone X", Price=9000, Description="Telefon", IsApproved = true},
                new Product {Name="Iphone 1", Price=12000, Description="Telefon"}
            };

            var categories = new List<Category>()
            {
                new Category() { Name = "Telefon", Description = "Telefon kategorisi" },
                new Category() { Name = "Bilgisayar", Description = "Bilgisayar kategorisi" },
                new Category() { Name = "Elektronik", Description = "Elektronik kategorisi" },
            };

            var productViewModel = new ProductViewModel()
            {
                Categories = categories,
                Products = products
            };

            return View(productViewModel);
        }

        public IActionResult About()
        {
            return View();
         }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
