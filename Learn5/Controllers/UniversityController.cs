using Microsoft.AspNetCore.Mvc;
using Learn5.Models;

namespace Learn5.Controllers
{
    public class UniversityController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(University uni)
        {
            return View(uni);
        }
    }
}
