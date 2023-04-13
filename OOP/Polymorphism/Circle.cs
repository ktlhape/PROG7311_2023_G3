using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            this.width = radius;
        }

        public override double CalcArea()
        {
            return Math.PI * (width * width);
        }
    }
}
