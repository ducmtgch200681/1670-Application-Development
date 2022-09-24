using Learn3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Learn3.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult StudentInfo()
        {
            var student = new Student();
            student.Id = 1;
            student.Name = "Mai";
            student.Grade = 9.5;
            student.Age = 20;
            student.Image = "https://as2.ftcdn.net/v2/jpg/02/91/44/67/1000_F_291446763_tLxmFv2DaIBVIpDIyYqxkTBtSM1IfnQO.jpg";

            var s1 = new Student()
            {
                Id = 2,
                Name = "Duc",
                Grade = 6.5,
                Age = 20,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcToFGNrBc-vKB17BOgt3PZT2RxNgV8MfRo73Q&usqp=CAU"
            };

            return View(s1);
        }

        public IActionResult StudentList()
        {
            List<Student> student = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Duke",
                    Age = 20,
                    Grade = 6.5,
                    Image = "https://img5.goodfon.com/original/2560x1440/6/80/kiss-kissing-girls-beautiful-love-pretty-lesbian-hair-face-l.jpg"
                },

                new Student
                {
                    Id = 1,
                    Name = "Mike",
                    Age = 20,
                    Grade = 10,
                    Image = "https://img.freepik.com/free-photo/close-up-handsome-young-gay-couple-kissing_23-2148083091.jpg?w=2000"
                }
            };

            return View(student);
        }
    }
}
