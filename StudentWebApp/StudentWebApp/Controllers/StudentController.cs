using Microsoft.AspNetCore.Mvc;
using StudentWebApp.Models;

namespace StudentWebApp.Controllers
{
    public class StudentController : Controller
    {
        List<Student> stList = new List<Student>();
        public IActionResult Index()
        {
            Populate();
            return View(stList);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VerifyLogin()
        {
            string username = Request.Form["txtUsername"].ToString();
            string pass = Request.Form["txtPass"].ToString();

            if (username.Equals("Kabelo") && pass.Equals("Pass.123"))
            {
                Populate();
                return View("Index", stList);
                //return RedirectToAction("Index", "Student");
            }
            else
            {
                return View("Login");
            }
        }
        public void Populate()
        {
            stList.Add(new Student("ST123", "Kabelo", "Tlhape", 70));
            stList.Add(new Student("ST246", "Thabo", "Mokoena", 75));
            stList.Add(new Student("ST456", "Caroline", "Smith", 64));
            stList.Add(new Student("ST369", "David", "Jones", 68));
            stList.Add(new Student("ST789", "Michael", "Smith", 89));
            stList.Add(new Student("ST321", "Kelvin", "Tshabalala", 65));
        }

    }
}
