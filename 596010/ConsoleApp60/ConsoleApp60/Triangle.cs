using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    internal class Triangle : Figure
    {
        private double side1;
        private double side2;
        private double side3;

        // Конструктор треугольника, параметры - длины сторон
        public Triangle(double s1, double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public override double GetArea()
        {
            double p = GetPerimeter() / 2; // Полупериметр
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public override double GetPerimeter()
        {
            return side1 + side2 + side3;
        }

        public override int CompareTo(Figure other)
        {
            return GetArea().CompareTo(other.GetArea());
        }
    }
}
