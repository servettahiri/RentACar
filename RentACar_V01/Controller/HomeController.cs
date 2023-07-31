using Microsoft.AspNetCore.Mvc;

namespace RentACar_V01.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
