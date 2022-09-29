using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Learn4.Models;

namespace Learn4.Controllers
{
    public class LaptopController : Controller
    {
        [Route ("/")]
        public IActionResult Index()
        {
            List<Laptop> laptop = new List<Laptop>()
            {
                new Laptop { Name = "lap1", Quantity = 3, Image = "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/plp/laptops/matebook-d-16-list.png", Price = 100 },
                new Laptop { Name = "lap2", Quantity = 5, Image = "https://minhancomputer.com/media/lib/09-01-2021/laptop-gaming.jpg", Price = 200}
            };
            return View(laptop);
        }
    }
}
