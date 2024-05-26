using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace делегатэкз
{//37
    class Program
    {
        //// Статический метод для вычисления площади треугольника
        //public static double S(double a, double b, double c)
        //{
        //    // Вычисление периметра треугольника
        //    double s = (a + b + c) / 2;

        //    // Вычисление площади треугольника
        //    return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        //}

        //// Объявление типа делегата, соответствующего методу S
        //public delegate double TriangleArea(double a, double b, double c);

        //задание 44
        /// <summary>
        /// статический метод int Sum (int m, int n), 
        /// который вычисляет и возвращает сумму всех целых чисел от m до n включительно
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        //public static int Sum(int m, int n)
        //{
        //    int sum = 0;
        //    for (int i = m; i <= n; i++)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}
        // Объявление типа делегата, соответствующего методу Sum
        //public delegate int SumDel(int m, int n);


        //задание 40
        public static double Average(int m, int n)
        {
            double sum = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return sum / count;
        }

        public delegate double AverageDelegate(int m, int n);

        static void Main(string[] args)
        {
            //// Объявление делегата и привязка его к методу S
            //TriangleArea area = S;

            //// Вычисление и вывод площади треугольника с разными сторонами
            //Console.WriteLine(area(3, 4, 5));
            //Console.WriteLine(area(6, 8, 10));
            //Console.WriteLine(area(9, 12, 15));

            //задание 44
            // Объявление делегата 
            //SumDel sumDel = Sum;

            //// вывод начального и конечного чисел с клавиатуры
            //Console.Write("Введите начальное число: ");
            //int m = int.Parse(Console.ReadLine());

            //Console.Write("Введите конечное число: ");
            //int n = int.Parse(Console.ReadLine());

            //// Вычисление и вывод суммы чисел от m до n с использованием делегата sumDel
            //Console.WriteLine($"Сумма чисел от {m} до {n}: {sumDel(m, n)}");


            //Задание 40.
            // Создание делегата averageDelegate типа AverageDelegate
            // и привязываем его к статическому методу Average
            AverageDelegate averageDelegate = Average;

            Console.Write("Введите начальное число: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите конечное число: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Среднее арифметическое от {m} до {n}: {averageDelegate(m, n)}");

            Console.ReadKey();
        }
    }
}
