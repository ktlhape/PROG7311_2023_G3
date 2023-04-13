using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    internal class Square : Shape
    {
        
        public Square(double side) : base(side, 0)
        {
            //this.length = side;
        }

        public override double CalcArea()
        {
            return length * length;
        }
    }
}
