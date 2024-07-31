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
            Person Person = new Person(33, "Vasyl");
            Person.Greet();
            Student Student = new Student(22, "Sara");
            Student.Greet();
            Student.ShowAge();
            Teacher Teacher = new Teacher(54, "John");
            Teacher.Greet();
            Teacher.Explain();

        }
    }
}
