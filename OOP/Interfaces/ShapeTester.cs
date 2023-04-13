using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle();
            rc.PrintShape();
            rc.Draw();
            Console.WriteLine("Area: " +  rc.CalcArea(5,4));
        }
    }
}
