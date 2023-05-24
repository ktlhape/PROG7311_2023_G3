using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using ConnectToDB.Models;
using System.Drawing;
using System.Data;
using ConnectToDB.Data;

namespace ConnectToDB.Controllers
{  
    public class StudentController : Controller
    {

        DBLayer dbLayer;
        public StudentController(IConfiguration configuration)
        {
            dbLayer = new DBLayer(configuration);
        }

        // GET: StudentController
        public ActionResult Index()
        {
            ViewBag.Type = 3;
            List<Student> stList = dbLayer.AllStudents();
            return View(stList);
        }

        public ActionResult StudentModules(string id)
        {
            List<Modules> stModules = dbLayer.StudentModules(id);
            return View(stModules);
        }
        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Delete(string id)
        {
            return View(dbLayer.GetStudent(id));
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            int x;
            try
            {
               x = dbLayer.DeleteStudent(id);
                if (x == 0)
                {
                    throw new Exception("Record not deleted");
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
