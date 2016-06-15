using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int Id = 1)
        {
            return HtmlEncoder.Default.Encode(
                "Hello " + name + ", Id: " + Id);
        }
    }
}