using Microsoft.AspNetCore.Mvc;

namespace SampleMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Name"] = "James Powell";
            ViewData["Age"] = 22;
            return View();
        }
    }
}
