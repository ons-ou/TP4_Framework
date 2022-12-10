using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP4.Data;

namespace TP4.Controllers
{
    public class UniversityController : Controller
    {
        private StudentRepository repo = new StudentRepository();

        public ViewResult Courses()
        {
            Debug.WriteLine("This is courses");
            
            return View(repo.GetAllCourses());
        }

        public ViewResult StudentsByCourse(string course)
        {
            ViewData["course"] = course;
            return View(repo.GetStudentsByCourse(course));
        }
    }
}
