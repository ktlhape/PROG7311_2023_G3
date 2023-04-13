using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class StudentTester
    {
        static void Main(string[] args)
        {
            //Build a student object

            Student st = new Student()
                .WithStudentID("1")
                .WithName("Kabelo", "Tlhape")
                .Build();
            Console.WriteLine(st.ToString());


        }
    }
}
