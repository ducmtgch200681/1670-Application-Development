using Microsoft.AspNetCore.Mvc;

namespace Learn5.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Check(string username, string password)
        {
            if(username == "admin" && password == "123456")
            {
                ViewBag.Result = true; 
            }
            else
            {
                ViewBag.Result = false;
            }
            return View();
        }
    }
}
