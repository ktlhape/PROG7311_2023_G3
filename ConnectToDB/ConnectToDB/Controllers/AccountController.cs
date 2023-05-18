using Microsoft.AspNetCore.Mvc;

namespace ConnectToDB.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }
    }
}
