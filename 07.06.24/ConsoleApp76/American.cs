using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp76
{
    internal class American : Person
    {
        public American(string name) : base(name) { }

        public override void SayGreeting()
        {
            Console.WriteLine($"{Name} says: Hi!");
        }
    }
}
