using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class Triangle : IShape
    {
        double length, height;
        public Triangle(double x, double y)
        {
            length = x;
            height = y;
        }

        public double CalcArea()
        {
            return (0.5 * length) * height;
        }

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}
