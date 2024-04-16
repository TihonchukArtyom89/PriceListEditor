using Microsoft.AspNetCore.Mvc;

namespace PriceListEditor.WebApplication.Controllers
{
    public class Product : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
