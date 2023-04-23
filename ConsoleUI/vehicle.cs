﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class vehicle
    {
        public int Year { get; set; } = 2;
        public string Make { get; set; } = "Acura";

        public string Model { get; set; } = "MDX";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}
