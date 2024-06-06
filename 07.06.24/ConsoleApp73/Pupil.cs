using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    abstract internal class Pupil
    {
        // Свойство для хранения фамилии ученика
        public string Surname { get; set; }

        // Конструктор, принимающий фамилию ученика
        public Pupil(string surname)
        {
            Surname = surname;
        }

        // Абстрактные методы, которые должны быть реализованы в производных классах
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
    }
}
