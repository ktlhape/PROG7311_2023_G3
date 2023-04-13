using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class ShapesTester
    {
        static void Main(string[] args)
        {
            string option;
            ShapeFactory fc = new ShapeFactory();
            Console.Write(fc.DisplayOptions());
            option = Console.ReadLine().ToUpper();
    
            IShape shape = fc.GetShape(option);
            Console.WriteLine(fc.DisplayDetails());
      
        }
    }
}
