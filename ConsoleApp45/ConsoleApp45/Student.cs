using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Student : Person
    {
        public int course;

        public Student(string name, string lastname, DateTime birth, string faculty, int course) : base(name, lastname, birth, faculty)
        {
            this.course = course;
        }

        public override void Info()
        {
            Console.WriteLine($"Студент: {name}, {lastname}, Возраст: {Age()}, Факультет:{faculty}, Курс: {course}");
        }
    }
}
