using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> arrPersons = new List<Person>();
            arrPersons.Add(new Person() { Name = "Настя", Age = 16 });
            arrPersons.Add(new Person() { Name = "Женя", Age = 30 });
            arrPersons.Add(new Person() { Name = "Миша", Age = 18 });
            arrPersons.Sort();
            for(int i =0; i<arrPersons.Count; i++)
            {
                Person obj = arrPersons[i];
                Console.WriteLine("Название: {0}, Возраст:{1}", obj.Name, obj.Age);
            }
            Console.ReadKey();


        }
    }
}
