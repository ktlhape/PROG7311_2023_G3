using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class Student
    {
       public string StudentId;
       public string Name;
       public string Surname;
       public string Username;
       public string Password;
       public int Age { get; set; }
        public string Campus { get; set; } = "VC Sandton";
       

        public Student(){ }
        public Student(string studentId, string name, string surname, string username, string password, int age, string campus)
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            Age = age;
            Campus = campus;
        }

        public Student WithStudentID(string id)
        {
            this.StudentId = id;
            return this;
        }
        public Student WithName(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            return this;
        }
        public Student WithCredentials(string username, string pass)
        {
            this.Username = username;
            this.Password = pass;
            return this;
        }
        private bool CheckBuild()
        {
            return StudentId.Length < 3;
        }
        public Student Build()
        {
            if (CheckBuild())
            {
                throw new Exception("Cannot create a " +
                    "student without student id");
            }
            return this;
        }
        public override string ToString()
        {
            return $"Student ID: {StudentId}\n" +
                $"Name: {Name} {Surname}\nAge: {Age}\n" +
                $"From: {Campus} Campus";
        }

    }
}
