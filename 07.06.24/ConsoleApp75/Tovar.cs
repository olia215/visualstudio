using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp75
{
    abstract internal class Tovar
    {
        // Общие поля
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Конструктор с параметрами
        public Tovar(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // Абстрактный метод для расчета стоимости
        public abstract decimal CalcSum();

        // Метод для вывода информации о товаре
        public virtual void Print()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Цена: {Price:C}");
        }
    }
}
