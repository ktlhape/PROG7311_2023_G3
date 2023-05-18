using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(4,5);
            rc.PrintShape();
            rc.Draw();
            Console.WriteLine("Area: " +  rc.CalcArea());

            IShape s = new Square(5);
            s.PrintShape();
            s.Draw();
            Console.WriteLine("Area: " + s.CalcArea());
        }
    }
}
