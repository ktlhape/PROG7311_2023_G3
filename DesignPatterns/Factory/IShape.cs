using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal interface IShape
    {
        double CalcArea();
        string Print();
    }
}
