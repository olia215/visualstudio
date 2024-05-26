using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    internal class Rectangle
    {
        // Поля для хранения длин сторон прямоугольника
        private double side1;
        private double side2;

        // Пользовательский конструктор для инициализации сторон прямоугольника
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Метод для вычисления площади прямоугольника
        public double AreaCalculator()
        {
            return side1 * side2;
        }

        // Метод для вычисления периметра прямоугольника
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        // Свойство для доступа к площади прямоугольника (только для чтения)
        public double Area
        {
            get { return AreaCalculator(); }
        }

        // Свойство для доступа к периметру прямоугольника (только для чтения)
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}
