using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Snippets.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public string Welcome(string name = "User", int numTimes = 0)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
