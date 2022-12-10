using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP4.Models;
using TP4.Models.Data;

namespace TP4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UniversityContext context = UniversityContext.Context;
            List<Student> students = context.Student.ToList();
            foreach (Student s in students){
                Debug.WriteLine(s.id + " " + s.first_name +" "+ s.last_name +" "+ s.university+ " " +s.phone_number, " ", s.timestamp);
            }
            Debug.WriteLine(context);
            return View();
        }

        public IActionResult Privacy()
        {
            UniversityContext context = UniversityContext.Context;
            Debug.WriteLine(context);
            return View();
        }

    }
}
