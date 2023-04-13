using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    internal class AnimalTester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======DOG=========");
            Animal dg = new Dog();
            dg.MakeSound();
            dg.Move();
            Console.WriteLine("\n=======EAGLE=========");
            Eagle eg = new Eagle();
            eg.MakeSound();
            eg.Move();

        }
    }
}
