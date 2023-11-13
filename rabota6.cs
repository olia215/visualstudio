using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        //Задача 1.Массив предназначен для хранения значений ростов двенадцати человек.С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.Вывести значения элементов с использованием цикла for. Найти средний рост.
        //static void Main(string[] args)
        //{
        //    Func();
        //}

        //static void Func()
        //{
        //    int[] n = new int[12];
        //    Random r = new Random();
        //    for (int i = 0; i < n.Length; i++)
        //    {
        //        n[i] = r.Next(163, 191);
        //    }
        //    Console.WriteLine("Значение элементов массива");
        //    for (int i = 0; i < n.Length; i++)
        //    {
        //        Console.WriteLine(n[i]);
        //    }
        //    int sum = 0;
        //    for (int i = 0; i < n.Length; i++)
        //    {
        //        sum += n[i];
        //    }
        //    int G = (int)sum / n.Length;
        //    Console.WriteLine("среднй рост=" + G);
        //    Console.ReadKey();
        //}

        //Задача 2.Заполнить массив из восьми элементов следующими значениями с использованием явной инициализации: первый элемент массива равен 37, второй — 0, третий — 50, четвертый — 46, пятый — 34, шестой — 46, седьмой — 0, восьмой —13.Найти максимальный и минимальный элементы массива.

        //static void Func()
        //{
        //    int[] omas = { 37, 0, 50, 46, 34, 46, 0, 13 };

        //    int maxElement = omas[0];
        //    int minElement = omas[0];

        //    foreach (int element in omas)
        //    {
        //        if (element > maxElement)
        //        {
        //            maxElement = element;
        //        }

        //        if (element < minElement)
        //        {
        //            minElement = element;
        //        }
        //    }

        //    Console.WriteLine("Массив: {" + string.Join(", ", omas) + "}");
        //    Console.WriteLine($"Максимальный элемент: {maxElement}");
        //    Console.WriteLine($"Минимальный элемент: {minElement}");
        //    Console.ReadKey();
        //}


        //Задача 3.Заполнить одномерный массив с клавиатуры и вывести элементы массива на экран в обратном порядке.

        //static void Func()
        //{
        //    Console.Write("Введите размер массива: ");
        //    int n = int.Parse(Console.ReadLine());
        //    int[] omas = new int[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write($"Введите элемент {i + 1}: ");
        //        omas[i] = int.Parse(Console.ReadLine());
        //    }

        //    Console.WriteLine("Элементы массива в обратном порядке:");

        //    for (int i = n - 1; i >= 0; i--)
        //    {
        //        Console.Write(omas[i] + " ");
        //    }
        //    Console.ReadKey();
        //}

        //Задача 4.Заполнить одномерный массив случайным образом от - 5 до 5 целыми числами.Увеличить все элементы в два раза.Вывести новые значения массива с использованием цикла foreach.

        //static void Func()
        //{
        //    int n = 5;
        //    int[] omas = new int[n];
        //    Random random = new Random();
        //    for (int i = 0; i < n; i++)
        //    {
        //        omas[i] = random.Next(-5, 6);
        //    }

        //    for (int i = 0; i < n; i++)
        //    {
        //        omas[i] *= 2;
        //    }

        //    Console.WriteLine("Новые значения массива:");
        //    foreach (int element in omas)
        //    {
        //        Console.Write(element + " ");
        //    }
        //    Console.ReadKey();
        //}

        //Задача 5.В массиве хранятся сведения об оценках 25 учеников по химии.Определить количество неуспевающих по химии учеников.

        //static void Func()
        //{

        //    int n = 25;
        //    int[] omas = new int[n];
        //    Random random = new Random();
        //    for (int i = 0; i < n; i++)
        //    {
        //        omas[i] = random.Next(2, 6);
        //    }
        //    int G = 0;
        //    foreach (int elem in omas)
        //    {
        //        if (elem < 3)
        //        {
        //            G++;
        //        }
        //    }

        //    Console.WriteLine("Оценки по химии:");
        //    foreach (int element in omas)
        //    {
        //        Console.Write(element + " ");
        //    }

        //    Console.WriteLine("\nКоличество неуспевающих учеников по химии: " + G);
        //    Console.ReadKey();
        //}


    }

}
