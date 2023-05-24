using ConnectToDB.Data;
using ConnectToDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;

namespace ConnectToDB.Controllers
{
    
    public class AccountController : Controller
    {
        DBLayer dbLayer;
        public AccountController(IConfiguration configuration)
        {
            dbLayer = new DBLayer(configuration);
        }
        public IActionResult Index()
        {
            return View("Login");
        }
        public IActionResult ValidateLogin()
        {
            string username, pass,id;
            username = "";
            pass = "";
            
            Student st = dbLayer.GetStudent(id);
            if (username.Equals(st.StudentID) && pass.Equals(st.Password))
            {
                return RedirectToAction("Index", "Student");
            }
            else
            {
                return RedirectToAction("Index", "Student");
            }

        }
    }
   
}
