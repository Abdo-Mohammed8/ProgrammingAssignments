using Microsoft.AspNetCore.Mvc;
using MVC01_DEMO.Models;

namespace MVC01_DEMO.Controlles
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return View("idex", new Movie);
        }
    }
}
