using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    internal class BadPupil : Pupil
    {
        
        // Конструктор, принимающий фамилию ученика
        public BadPupil(string surname) : base(surname) { }

        // Переопределение метода Study для двоечника
        public override void Study()
        {
            Console.WriteLine($"{Surname}: Учится плохо!");
        }

        // Переопределение метода Read для двоечника
        public override void Read()
        {
            Console.WriteLine($"{Surname}: Читает очень медленно!");
        }

        // Переопределение метода Write для двоечника
        public override void Write()
        {
            Console.WriteLine($"{Surname}: Пишет с большим количеством ошибок!");
        }

        // Переопределение метода Relax для двоечника
        public override void Relax()
        {
            Console.WriteLine($"{Surname}: Отдыхает, играя в компьютерные игры!");
        }
    }
}
