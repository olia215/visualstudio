using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    abstract internal class Vehicle
    {
        // Поля координат
        public double X { get; set; }
        public double Y { get; set; }

        // Поля параметров транспортного средства
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        // Конструктор с параметрами
        public Vehicle(double x, double y, double price, double speed, int year)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }

        // Метод для вывода информации о транспортном средстве
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Координаты: ({X}, {Y})");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine($"Год: {Year}");
        }
    }
}
