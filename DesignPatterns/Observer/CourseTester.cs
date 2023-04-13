using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class CourseTester
    {
        static void Main(string[] args)
        {
            Course it = new Course("2060", "Information Tech.", 75500);
            Course acc = new Course("2065", "Accounting", 75500);
            it.Attach(new Student("ST123", "Kabelo"));
            it.Attach(new Student("ST246", "Carol"));
            it.Attach(new Student("ST135", "Thabo"));
            it.Attach(new Student("ST456", "Kelvin"));

            acc.Attach(new Student("ST456", "Kelvin"));
            acc.Attach(new Student("ST789", "Smith"));
            acc.Cost = 85000;
            it.Cost = 105000;
            Console.Read();
        }
    }
}
