using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{/// <summary>
/// Базовый класс: Сотрудник
/// </summary>
    internal class Employee
    {/// <summary>
     /// поля: фамилия
     /// </summary>
        public string Surname { get; set; }
        /// <summary>
        ///поле имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// минимальная зарплата
        /// </summary>
        public decimal MinimumSalary { get; set; }
        /// <summary>
        /// повышающий коэффициент
        /// </summary>
        public decimal IncrementCoefficient { get; set; }

        public Employee(string Surname, string Name, decimal minimumSalary, decimal incrementCoefficient)
        {
            Surname = Surname;
            Name = Name;
            MinimumSalary = minimumSalary;
            IncrementCoefficient = incrementCoefficient;
        }
        /// <summary>
        /// Метод: Доход k *p
        /// </summary>
        /// <returns></returns>
        public virtual decimal GetIncome()
        {
            return IncrementCoefficient * MinimumSalary;
        }
        /// <summary>
        /// вывод информации
        /// </summary>
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Минимальная заработная плата: {MinimumSalary}");
            Console.WriteLine($"Коэффициент приращения: {IncrementCoefficient}");
            Console.WriteLine($"Доход: {GetIncome()}");
        }
    }
}
