using Microsoft.AspNetCore.Mvc;

namespace Learn2.Controllers
{
    public class TestController : Controller
    {
        [Route ("/")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hanoi()
        {
            return View();
        }

        public IActionResult CanTho()
        {
            return View();
        }

        public IActionResult DaNang()
        {
            return View();
        }
    }
}
