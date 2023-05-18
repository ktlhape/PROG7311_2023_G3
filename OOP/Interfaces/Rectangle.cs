using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class Rectangle : IShape, IDrawable
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double x, double y)
        {
            Length = x;
            Width = y;
        }
        public void ApplyColor()
        {
            Console.WriteLine("Color: Red");
        }

        public double CalcArea()
        {
       
            return Length * Width;
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
