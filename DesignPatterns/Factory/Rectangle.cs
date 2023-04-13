using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class Rectangle : IShape
    {
        double length, width;
        public Rectangle(double x, double y)
        {
            this.length = x;
            this.width = y;
        }

        public double CalcArea()
        {
            return length * width;
        }

        public string Print()
        {
            return $"Area of {this.ToString()}: {CalcArea()}";
        }
    }
}
