using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("buck");
        }

        public override void Move()
        {
            Console.WriteLine("Run");
        }
    }
}
