using GPA_CALCULATOR.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GPA_CALCULATOR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //private static List<Student> students = new List<Student>();
        //private static List<Result> Results = new List<Result>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateGPA(List<string> subject, List<int> creditUnit, List<int> gradePoint)
        {

            int totalCredits = 0;
            int totalGradePoints = 0;
             
            
            for (int i = 0; i < subject.Count; i++)
            {
                
                totalCredits += creditUnit[i];
                totalGradePoints += gradePoint[i] * creditUnit[i];
            }

            
            double gpa = Math.Round((double)totalGradePoints / totalCredits, 2);

            
            ViewBag.GPA = gpa;

            return View("Privacy");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
// if(student != null)
//    student.id = students.Count + 1;
//  student.Add(student);
//}

/*
 
 */
