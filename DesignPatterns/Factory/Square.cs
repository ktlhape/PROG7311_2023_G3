using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class Square : IShape
    {
        double side;
        public Square(double x){side = x;}

        public double CalcArea()
        {
            return side * side;
        }

        public string Print()
        {
            return $"Area of {this.ToString()}: {CalcArea()}";
        }
    }
}
