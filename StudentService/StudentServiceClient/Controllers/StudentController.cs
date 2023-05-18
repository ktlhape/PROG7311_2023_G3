using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StServiceReference;

namespace StudentServiceClient.Controllers
{
    public class StudentController : Controller
    {
        private StServiceClient client = new StServiceClient();

        // GET: StudentController
        public ActionResult Index()
        {
            List<Student> stList = client.AllStudentsAsync().Result;

            return View(stList);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            Student st = client.GetStudentAsync(id).Result;
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
