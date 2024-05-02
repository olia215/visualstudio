using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    internal class Segment<T>
    {
        // Поля для координат точек отрезка (x1, y1) и (x2, y2)
        private T x1;
        private T y1;
        private T x2;
        private T y2;

        // Конструктор класса для инициализации координат точек отрезка
        public Segment(T x1, T y1, T x2, T y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        // Метод для вычисления длины отрезка
        public double CalculateLength()
        {
            // Вычисляем разность координат по x и по y
            dynamic dx = Convert.ToDouble(x2) - Convert.ToDouble(x1);
            dynamic dy = Convert.ToDouble(y2) - Convert.ToDouble(y1);

            // Вычисляем длину отрезка по теореме Пифагора
            double length = Math.Sqrt(dx * dx + dy * dy);

            return length;
        }

        // Метод для вывода информации об отрезке
        public void PrintInfo()
        {
            Console.WriteLine($"Сегмент:  Точка1({x1}, {y1}), Точка2({x2}, {y2})");
        }
    }
}
