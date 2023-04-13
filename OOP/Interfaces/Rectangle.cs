using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class Rectangle : IShape, IDrawable
    {
        public void ApplyColor()
        {
            Console.WriteLine("Color: Red");
        }

        public double CalcArea(double x, double y)
        {
       
            return x * y;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing"); 
        }

        public void PrintShape()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
