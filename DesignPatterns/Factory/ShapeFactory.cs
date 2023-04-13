using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class ShapeFactory
    {
        IShape myShape = null;

        public string DisplayOptions()
        {
            return "Enter (R - Rectangle, S - Square, C - Circle, T - Triangle): ";
        }

        public IShape GetShape(string option)
        {
           
            if (option.Equals("R"))
            {
                double length, width;
                Console.Write("Enter length: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter width: ");
                width = Convert.ToDouble(Console.ReadLine());
                myShape = new Rectangle(length, width);
            }else if (option.Equals("C"))
            {
                double raduis;
                Console.Write("Enter radius: ");
                raduis = Convert.ToDouble(Console.ReadLine());
                myShape = new Circle(raduis);
            }else if (option.Equals("S"))
            {
                double side;
                Console.Write("Enter side: ");
                side = Convert.ToDouble(Console.ReadLine());
                myShape = new Square(side);
            }
            else if (option.Equals("T"))
            {
                double length, height;
                Console.Write("Enter length: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter height: ");
                height = Convert.ToDouble(Console.ReadLine());
                myShape = new Triangle(length, height);
            }
            return myShape;
        }

        public string DisplayDetails()
        {
            return $"Area of {myShape.GetType().Name}: {myShape.CalcArea()}";
        }
      
    }
}
