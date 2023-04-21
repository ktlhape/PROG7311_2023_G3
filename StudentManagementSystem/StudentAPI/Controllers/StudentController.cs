using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Data;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All")]
        public ActionResult<List<Student>> AllStudents()
        {
            return StudentDB.Students;
        }

        [HttpGet]
        [Route("{id}")]
        public Student GetStudentByID(int id)
        {
            return StudentDB.Students.FirstOrDefault(s => s.StudentID == id);
        }
        [HttpGet]
        [Route("{name:alpha}")]
        public Student GetStudentByName(string name)
        {
            return StudentDB.Students.FirstOrDefault(s => s.Firstname.Equals(name));
        }

        [HttpDelete]
        [Route("{id}")]
        public bool DeleteStudent(int id)
        {
            var st = StudentDB.Students.FirstOrDefault(s => s.StudentID == id);
            return StudentDB.Students.Remove(st);
        }
        [HttpPut]
        [Route("{id}")]
        public bool UpdateStudent(int id, string newName, 
            string newSurname, int newAge)
        {
            var st = StudentDB.Students.FirstOrDefault(s => s.StudentID == id);
            if (st != null)
            {
                st.Firstname = newName;
                st.Lastname = newSurname;
                st.Age = newAge;
                return true;
            }
            return false;
        }
     






    }
}
