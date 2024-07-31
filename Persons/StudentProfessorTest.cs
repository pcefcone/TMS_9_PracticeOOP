using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_9_PracticeOOP.Persons
{
    internal class StudentProfessorTest
    {
        public void Main()
        {
            Person Person = new Person(age: 33, name: "Vasyl");
            Person.Greet();
            Student Student = new Student(age: 22, name: "Sara");
            Student.Greet();
            Student.ShowAge();
            Teacher Teacher = new Teacher(54, "John");

        }
    }
}
