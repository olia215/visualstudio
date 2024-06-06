using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    internal class ExcelentPupil : Pupil
    {
        // Конструктор, принимающий фамилию ученика
        public ExcelentPupil(string surname) : base(surname) { }

        // Переопределение метода Study для отличника
        public override void Study()
        {
            Console.WriteLine($"{Surname}: Учится отлично!");
        }

        // Переопределение метода Read для отличника
        public override void Read()
        {
            Console.WriteLine($"{Surname}: Читает очень быстро!");
        }

        // Переопределение метода Write для отличника
        public override void Write()
        {
            Console.WriteLine($"{Surname}: Пишет без ошибок!");
        }

        // Переопределение метода Relax для отличника
        public override void Relax()
        {
            Console.WriteLine($"{Surname}: Отдыхает, смотря телевизор!");
        }
    }
}
