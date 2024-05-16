using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace делегаты3
{
    class Program
    {
        // Создание статического метода для вычисления среднего арифметического
        static double Average(int m, int n) // Объявление статического метода Average с двумя целочисленными параметрами и возвращаемым значением типа double
        {
            double sum = 0; // Объявление переменной sum и инициализация ее значением 0
            int count = 0; // Объявление переменной count и инициализация ее значением 0

            for (int i = m; i <= n; i++) // Начало цикла с переменной i, начиная с m и заканчивая n
            {
                sum += i; // Увеличение суммы на значение i
                count++; // Увеличение счетчика на 1
            }

            return sum / count; // Возврат среднего арифметического (сумма / количество)
        }

        // Объявление типа делегата, соответствующего методу
        delegate double AverageDelegate(int m, int n); // Объявление делегата AverageDelegate с двумя целочисленными параметрами и возвращаемым значением типа double
        static void Main(string[] args)
        {
            //// Создание делегата
            //AverageDelegate averageDelegate; // Объявление переменной делегата AverageDelegate

            //// Применение делегата в программе
            //averageDelegate = Average; // Присвоение делегату ссылки на метод Average

            //Console.WriteLine($"Среднее арифметическое чисел от 1 до 5: {averageDelegate(1, 5)}"); // Вывод среднего арифметического в консоль для чисел от 1 до 5
            //Console.WriteLine($"Среднее арифметическое чисел от 10 до 20: {averageDelegate(10, 20)}"); // Вывод среднего арифметического в консоль для чисел от 10 до 20
            //Console.WriteLine($"Среднее арифметическое чисел от -5 до 5: {averageDelegate(-5, 5)}"); // Вывод среднего арифметического в консоль для чисел от -5 до 5

            // Создание делегата
            AverageDelegate averageDelegate;

            // Применение делегата в программе
            averageDelegate = Average;

            Console.WriteLine("Введите первое число:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Среднее арифметическое чисел от {firstNumber} до {secondNumber}: {averageDelegate(firstNumber, secondNumber)}");

            Console.ReadKey();
        }
    }
}
