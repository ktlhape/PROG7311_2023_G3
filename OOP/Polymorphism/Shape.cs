using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    internal class Shape
    {
       protected double length, width;
        public Shape(){}
        public Shape(double x, double y)
        {
            this.length = x;
            this.width = y;
        }
        public virtual double CalcArea()
        {return length * width;}

    }
}
