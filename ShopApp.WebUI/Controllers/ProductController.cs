using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;

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

        public IActionResult List(int? id, string q)
        {
            //Console.WriteLine(RouteData.Values["controller"]);
            //Console.WriteLine(RouteData.Values["action"]);
            //Console.WriteLine(RouteData.Values["id"]);

            // QueryString
            //Console.WriteLine(q);
            //Console.WriteLine(HttpContext.Request.Query["q"].ToString());

            var products = ProductRepository.Products;

            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i => i.Name.Contains(q) || i.Description.Contains(q)).ToList();
            }
            var productViewModel = new ProductViewModel()
            {
                Products = products
            };


            return View(productViewModel);
        }

        public IActionResult Details(int id)
        {

            return View(ProductRepository.GetProductById(id));
        }

        public IActionResult Create(string name, double price)
        {
            Console.WriteLine(name);
            Console.WriteLine(price);
            return View();
        }
    }
}
