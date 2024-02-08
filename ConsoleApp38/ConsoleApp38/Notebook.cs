using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Notebook
    {
        public string Name;
        public int Number;

        public Notebook(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"тетрадь: {Name}, номер страницы: {Number}");
        }

        public virtual int GetCost()
        {
            return 15 * Number;
        }
    }
}
