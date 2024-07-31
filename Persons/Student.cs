using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_9_PracticeOOP.Persons
{
    internal class Student : Person
    {
        public Student(int age, string name) : base(age, name)
        {

        }
        public void Study()
        {
            Console.WriteLine("I am studying");
        }

        public void ShowAge()
        {
            Console.WriteLine($"I have {age} years");
        }
    }
}
