using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Person: IComparable<Person>
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public int CompareTo(Person obj)
        {
            return Name.CompareTo(obj.Name);
        }
    }
}
