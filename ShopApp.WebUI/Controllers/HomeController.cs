using Microsoft.AspNetCore.Mvc;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting = saat > 12 ? "İyi günler" : "Günaydın";
            ViewBag.UserName = "Ahmet";

            return View();
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
