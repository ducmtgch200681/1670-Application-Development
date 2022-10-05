using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Learn6.Models;

namespace Learn6.Controllers
{
    public class PersonController : Controller
    {
        public static List<Person> persons = new List<Person>();
        [Route("/")]
        public IActionResult Index()
        {
            return View(persons);
        }

        // 2 actions
        // 1 action GET to render view
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // 1 action POST to "xu li du lieu tu form"
        [HttpPost]
        public IActionResult Add(Person person)
        {
            persons.Add(person);
            //not recommend (return view): giu nguyen duong dan + duplicaate add neu bam F5
            //return View("Index", persons);
            //recommend (RedirectToAction): thay doi duong dan + khong bi duplicate hi F5
            return RedirectToAction("Index", persons);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            persons.RemoveAt(id);
            return RedirectToAction("Index", persons);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = persons[id];
            ViewBag.Id = id;
            return View(person);
        }
        [HttpPost]
        public IActionResult Edit(Person person, int id)
        {
            persons[id] = person;
            //person.Name = person.Name;
            //person.Age = person.Age;
            //person.Tele = person.Tele;
            //person.Image = person.Image;
            return RedirectToAction("Index", persons);
        }
    }
}
