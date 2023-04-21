using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentAPI.Data;
using StudentAPI.Models;

namespace StudentWebAppl.Controllers
{
    public class StudentController : Controller
    {
        Uri _baseAddress = new Uri("http://localhost:5295/api/");
        HttpClient _client;

        public StudentController()
        {
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
        }
        /// <summary>
        /// To read data from the HttpResponse
        /// then return the Index View with a list of Students
        /// </summary>
        /// <returns>Index View</returns>
        [HttpGet]
        public ActionResult Index()
        {
           
            List<Student> stList = new List<Student>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "Student/AllStudents/All").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content
                    .ReadAsStringAsync().Result;
                stList = JsonConvert.DeserializeObject<List<Student>>(data);
            }

            return View(stList);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            Student st = new Student();
           HttpResponseMessage response = 
                _client.GetAsync($"{_client.BaseAddress}Student/GetStudentByID/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                st = JsonConvert.DeserializeObject<Student>(data);
            }
            return View(st);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
