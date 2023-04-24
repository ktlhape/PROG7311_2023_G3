using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using StudentService.Data;
using StudentService.Models;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStService" in both code and config file together.
    [ServiceContract]
    public interface IStService
    {
        [OperationContract]
        //return a list of students
        List<Student> AllStudents();
        //return a single student object
        [OperationContract]
        Student GetStudent(int id);
    }
}
