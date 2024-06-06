using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    abstract internal class Person
    {
        // Свойство для хранения имени человека
        public string Name { get; set; }

        // Конструктор с параметром для задания имени
        public Person(string name)
        {
            Name = name;
        }

        // Абстрактный метод для приветствия
        public abstract void SayGreeting();
    }
}
