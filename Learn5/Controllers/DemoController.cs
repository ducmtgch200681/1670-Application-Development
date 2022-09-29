using Microsoft.AspNetCore.Mvc;

namespace Learn5.Controllers
{
    public class DemoController : Controller
    {
        [Route ("/")]
        public IActionResult Input()
        {
            return View();
        }

        public IActionResult Output(string name, int age, string image)
        {
            ViewData["Name"] = name;
            ViewBag.Age = age;
            ViewBag.Image = image;
            return View();
        }
    }
}
