using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_9_PracticeOOP.Persons
{
    internal class Person
    {
        protected int age;
        protected string name;
        public Person(int age, string name) 
        { 
            this.age = age;
            this.name = name;
        }
        public void Greet()
        {
            Console.WriteLine($"Hi! My name is {name}");
        }
        public void SetAge(int age) 
        {
            if (age < 0)
            {
                this.age = age;
            }
            else
                Console.WriteLine(age);

        }

    }
}
