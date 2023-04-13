using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            Shape sh = new Shape(4, 5);
            Console.WriteLine("Shape Area: " + sh.CalcArea());

            Square sq = new Square(6);
            Console.WriteLine("Square Area: " + sq.CalcArea());

            Shape c = new Circle(5);
            Console.WriteLine("Circle Area: " + Math.Round(c.CalcArea(),2));

            Rectangle rc = new Rectangle(5,6);
            Console.WriteLine("Rectangle Area: " + rc.CalcArea());

        }
    }
}
