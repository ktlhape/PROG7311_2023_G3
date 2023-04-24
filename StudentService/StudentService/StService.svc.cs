using StudentService.Data;
using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StService.svc or StService.svc.cs at the Solution Explorer and start debugging.
    public class StService : IStService
    {
        public List<Student> AllStudents()
        {
            return StudentDB.Students;
        }

        public Student GetStudent(int id)
        {
            return StudentDB.Students
                .FirstOrDefault(s => s.StudentID == id);
        }
    }
}
