using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{/// <summary>
///  Класс Triangle, реализующий интерфейс IShape
/// </summary>
    internal class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными числами");
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Данные стороны не образуют правильный треугольник");
            }

            A = a;
            B = b;
            C = c;
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
    }
}
