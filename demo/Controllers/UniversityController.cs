using demo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace demo.Controllers
{
    public class UniversityController : Controller
    {
        private readonly ApplicationDbContext context;

        public UniversityController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {                
            var universities = context.Universities.ToList();
            return View(universities);
        }

        public IActionResult Info(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var universities = context.Universities
                                      .Include(u => u.Students)
                                      .FirstOrDefault(u => u.Id == id);
            //Note: khi muon truy xuat du lieu 
            return View(universities);
        }
    }
}
