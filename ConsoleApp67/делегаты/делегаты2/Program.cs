using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        // Создание статических методов вычисления и вывода операций
        static void Sum(int a, int b)
        {
            Console.WriteLine($"Сумма чисел {a} и {b} равна: {a + b}");
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine($"Разность чисел {a} и {b} равна: {a - b}");
        }

        static void Mult(int a, int b)
        {
            Console.WriteLine($"Произведение чисел {a} и {b} равно: {a * b}");
        }

        static void Div(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"Результат деления числа {a} на {b} равен: {(double)a / b}");
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
        }

        // Объявление типа делегата, соответствующего методам
        delegate void CalculationDelegate(int a, int b);
        static void Main(string[] args)
        {
            // Создание делегата
            CalculationDelegate calculation;

            // Применение делегата для вызова методов
            calculation = Sum;
            calculation(5, 3); // Вызов метода для сложения

            calculation = Sub;
            calculation(5, 3); // Вызов метода для вычитания

            calculation = Mult;
            calculation(5, 3); // Вызов метода для умножения

            calculation = Div;
            calculation(5, 3); // Вызов метода для деления

            Console.ReadKey();
        }
    }
}
