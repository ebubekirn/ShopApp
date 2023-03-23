using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category() { Name = "Telefon", Description = "Telefon kategorisi" },
                new Category() { Name = "Bilgisayar", Description = "Bilgisayar kategorisi" },
                new Category() { Name = "Elektronik", Description = "Elektronik kategorisi" },
            };

            return View(categories);
        }
    }
}
