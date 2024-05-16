using Microsoft.AspNetCore.Mvc;

namespace Practic16._05._2024.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ActionName("first")]
        public string FirstMethod()
        {
            return "FirstMethod";
        }
        [NonAction]
        public string LastMethod()
        {
            return "LastMethod";
        }
    }
}
