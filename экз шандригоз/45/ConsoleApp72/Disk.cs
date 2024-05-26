using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{/// <summary>
///   Класс Disk, реализующий интерфейс IShape
/// </summary>
    internal class Disk : IShape
    {
        public double Radius { get; }

        public Disk(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом");
            }

            Radius = radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
