using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class Square : IShape, IDrawable
    {
        public double Side { get; set; }
        public Square(double x)
        {
            Side = x;
        }
        public double CalcArea()
        {
            return Side * Side;
        }

        public void PrintShape()
        {
            Console.WriteLine("Square");
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void ApplyColor()
        {
            throw new NotImplementedException();
        }
    }
}
