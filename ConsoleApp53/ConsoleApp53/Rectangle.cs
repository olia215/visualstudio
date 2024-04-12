using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{/// <summary>
///  Класс прямоугольника
/// </summary>
    internal class Rectangle : figures
    { // Приватные поля класса - ширина и высота 
        private double width;
        private double height;

        // Конструктор
        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        // Методы интерфейса
        public double CalculateArea()
        {
            return width * height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (width + height);
        }
    }
}
