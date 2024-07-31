using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_9_PracticeOOP.Cars
{
    internal class SportCar : Car
    {
        public SportCar(int fuel) : base(fuel)
        {
        }

        public override void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("The SportCar is moving");
            }
            else
            {
                Console.WriteLine("Add fuel to your SportCar");
            }
        }
    }
}
