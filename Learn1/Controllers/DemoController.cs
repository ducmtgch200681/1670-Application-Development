using Microsoft.AspNetCore.Mvc;

namespace Learn1.Controllers
{
    public class DemoController : Controller
    {
        /*
        Perpose: Render file view
        place: Views/Demo/Index.cshtml
        "Demo": controller name (class)
        "Index": Action name (method) 
        */
        public IActionResult Index()
        {
            return View();
        }

        [Route("/")]
        public IActionResult ARandomGrace()
        {
            return View();
        }
    }
}
