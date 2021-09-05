using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Snippets.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name = "User", int numTimes = 0)
        {
            ViewData["Name"] = name;
            ViewData["NumTimes"] = numTimes;
            
            return View();
        }
    }
}
