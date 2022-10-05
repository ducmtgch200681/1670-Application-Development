using Learn9.Models;
using Microsoft.AspNetCore.Mvc;

namespace Learn9.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create (Employee emp)
        {
            if(ModelState.IsValid)
            {
                return View("Result", emp);
            }
            return View();
        }

        public IActionResult Result(Employee emp)
        {
            return View(emp);
        }
    }
}
