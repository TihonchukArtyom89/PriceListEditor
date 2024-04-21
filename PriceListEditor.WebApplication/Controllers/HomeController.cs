using Microsoft.AspNetCore.Mvc;

namespace PriceListEditor.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
