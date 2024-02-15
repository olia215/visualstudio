using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{/// <summary>
/// потомок класс
/// </summary>
    internal class Engineer : Employee
    {/// <summary>
     /// поле: n – количество разработанных проектов
     /// </summary>
        public int N { get; set; }

        public Engineer(string Surname, string Name, decimal minimumSalary, decimal incrementCoefficient, int numberOfProjects)
            : base(Surname, Name, minimumSalary, incrementCoefficient)
        {
            N = numberOfProjects;
        }
        /// <summary>
        /// Доход инженера увеличить в n/10 раз, если n>10.
        /// </summary>
        /// <returns></returns>
        public override decimal GetIncome()
        {
            if (N > 10)
            {
                return base.GetIncome() * N / 10;
            }
            else
            {
                return base.GetIncome();
            }
        }
        /// <summary>
        /// вывод 
        /// </summary>
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество проектов: {N}");
        }
    }
}
