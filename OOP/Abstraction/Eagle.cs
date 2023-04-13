﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    internal class Eagle : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Scream");
        }

        public override void Move()
        {
            Console.WriteLine("Fly");
        }
    }
}
