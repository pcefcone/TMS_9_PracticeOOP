using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_9_PracticeOOP.Cars
{
    internal class Car
    {
        protected int fuel;

        public Car(int fuel)
        {
            this.fuel = fuel;
        }

        public virtual void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("The car is moving");
            }
            else
            {
                Console.WriteLine("Add fuel to ypur vehicle");
            }
        }

        public virtual bool Refuel(int fuel)
        {
            if (fuel > 0)
            {
                this.fuel += fuel;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
