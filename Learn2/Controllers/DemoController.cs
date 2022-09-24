using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace Learn2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Demo()
        {
            return View();
        }

        public IActionResult PassData()
        {
            var year = DateAndTime.Now.Year;
            var YoB = 2002;
            var age = year - YoB;
            var gen = 'M';
            var gender = "";
            if (gen == 'M' || gen == 'm')
            {
                gender = "Male";
            }
            else if (gen == 'F' || gen == 'f')
            {
                gender = "Female";
            }
            else
            {
                gender = "LGBT";
            }

            List<string> poems = new List<string>()
            {
                "Me", "May", "Beo"
            };
            poems.Add("Qua");
            poems.Add("Di");

            ViewData["Age"] = age;
            ViewData["Gender"] = gender;
            ViewData["Phone"] = "113";

            ViewBag.Poem = poems;

            return View();
        }
    }
}
