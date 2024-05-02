using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    internal class Triangle<T>
    {
        // Поля для сторон треугольника a, b и c
        private T a;
        private T b;
        private T c;

        // Конструктор класса для инициализации сторон треугольника
        public Triangle(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Свойство для доступа к полю a с дополнительной логикой
        public T A
        {
            get { return a; }
            set { a = value; }
        }

        // Свойство для доступа к полю b с дополнительной логикой
        public T B
        {
            get { return b; }
            set { b = value; }
        }

        // Свойство для доступа к полю c с дополнительной логикой
        public T C
        {
            get { return c; }
            set { c = value; }
        }

        // Метод для вывода информации о треугольнике
        public void PrintInfo()
        {
            Console.WriteLine($"Стороны треугольника: a = {a}, b = {b}, c = {c}");
        }

        // Метод для расчета площади треугольника (по формуле Герона)
        public double CalculateArea()
        {
            // Переводим значения a, b и c в тип double для дальнейших вычислений
            double sideA = Convert.ToDouble(a);
            double sideB = Convert.ToDouble(b);
            double sideC = Convert.ToDouble(c);

            // Вычисляем полупериметр
            double semiPerimeter = (sideA + sideB + sideC) / 2;

            // Вычисляем площадь по формуле Герона
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

            return area;
        }
    }
}