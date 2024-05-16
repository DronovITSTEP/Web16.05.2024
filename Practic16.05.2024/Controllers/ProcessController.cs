using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Practic16._05._2024.Controllers
{
    public class ProcessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [Route("search/{name}")]
        [HttpGet]
        public ActionResult Search(string name)
        {
            var input = WebUtility.HtmlEncode(name);
            
            return Content(input);
        }
        public IActionResult About()
        {
            return Content("<ul>" +
                "<li>First</li>" +
                "<li>Second</li>" +
                "<li>Third</li>" +
                "</ul>", "text/html");
        }
    }
}
