using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIDemo.Models;

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public string GetName()
        {
            return "Kabelo";
        }
        [HttpPost]
        public IEnumerable<Student> Students()
        {
            return new List<Student> { 
            new Student("Kabelo","Tlhape"),
            new Student("Carol","Smit"),
            new Student("John","Jones"),
            new Student("Michael","Jordan"),
            new Student("Roger","Federer"),
            }.ToList();
        }

    }
}
