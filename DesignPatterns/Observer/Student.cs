using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class Student : IObserver
    {
        public string StNumber { get; set; }
        public string Name { get; set; }
        public Student(string stNum, string theName)
        {
            this.StNumber = stNum;
            this.Name = theName;
        }

        public void Update(Course course)
        {
            Console.WriteLine($"Notified {Name}. " +
                $"The cost for {course.Desc} " +
                $"has changed to {course.Cost.ToString("C2")}");
        }
    }
}
