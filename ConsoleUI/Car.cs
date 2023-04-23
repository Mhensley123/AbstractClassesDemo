using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : vehicle
    {
        public Car()
        {

        }

        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            
            {
                Console.WriteLine("This car is in drive");
            }
        }
    }

}
