using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    abstract internal class Figure
    {
        public abstract double GetArea(); // Абстрактный метод для вычисления площади фигуры
        public abstract double GetPerimeter(); // Абстрактный метод для вычисления периметра фигуры

        public void PrintInfo() // Метод для вывода информации о фигуре на экран
        {
            Console.WriteLine($"Площадь: {GetArea()}");
            Console.WriteLine($"Периметр: {GetPerimeter()}");
        }

        public abstract int CompareTo(Figure other); // Абстрактный метод для сравнения фигур
    }
}
