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

        public string Welcome(string name = "User", int numTimes = 0)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
