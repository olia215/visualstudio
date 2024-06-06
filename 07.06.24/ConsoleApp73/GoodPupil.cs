using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    internal class GoodPupil : Pupil
    {
        // Конструктор, принимающий фамилию ученика
        public GoodPupil(string surname) : base(surname) { }

        // Переопределение метода Study для хорошиста
        public override void Study()
        {
            Console.WriteLine($"{Surname}: Учится хорошо!");
        }

        // Переопределение метода Read для хорошиста
        public override void Read()
        {
            Console.WriteLine($"{Surname}: Читает достаточно быстро!");
        }

        // Переопределение метода Write для хорошиста
        public override void Write()
        {
            Console.WriteLine($"{Surname}: Пишет с небольшими ошибками!");
        }

        // Переопределение метода Relax для хорошиста
        public override void Relax()
        {
            Console.WriteLine($"{Surname}: Отдыхает, играя в шахматы!");
        }
    }
}
