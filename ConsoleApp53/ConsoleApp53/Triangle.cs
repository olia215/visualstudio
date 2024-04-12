using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{/// <summary>
/// класс треугольник 
/// </summary>
    internal class Triangle : figures
    {// Приватные поля класса - стороны треугольника
        private double sideA;
        private double sideB;
        private double sideC;

       /// <summary>
       /// конструктор
       /// </summary>
       /// <param name="a"></param>
       /// <param name="b"></param>
       /// <param name="c"></param>
        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        /// <summary>
        ///  Методы интерфейса
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            //Используем формулу Герона для нахождения площади треугольника
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
