using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class CompanyTester
    {
        static void Main(string[] args)
        {
            Company c1 = Company.GetInstance();
            c1.Name = "VC Sandton";
            Company c2 = Company.GetInstance();
            c2.Name = "VC Midrand";

            Console.WriteLine(c1.Name);
            Console.WriteLine(c2.Name);

          

        }
  
    }
}
