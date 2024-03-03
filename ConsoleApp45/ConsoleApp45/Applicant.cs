using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp45
{
    internal class Applicant : Person
    {
        public Applicant(string name, string lastname, DateTime birth, string faculty) : base(name, lastname, birth, faculty)
        {

        }

        public override void Info()
        {
            Console.WriteLine($"ФИО: {name}, {lastname}, Возраст: {Age()}, Факультет:{faculty}");
        }

    }
}
