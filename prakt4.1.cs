using System;

namespace ConsoleApp7
{
    class Program
    {
        //Задача 1.Составить программу, в результате которой величина а меняется значением с величиной b, а величина b — с величиной c.
        //Определить метод, осуществляющий обмен значениями двух переменных величин.
        // public static void Func(int a, int b)
        //{
        //    int x = b;
        //    b = a; a = x;
        //    Console.WriteLine("a= "+a + "  b= "+b);

        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("Введите а=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("Введите b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Func(a, b);
        //}

        //Задача 2. Ввести три целых числа и вывести их в порядке возрастания значений.
        //static void Main()
        //{
        //    Console.Write("Введите а=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("Введите b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.Write("Введите c=");
        //    int c = int.Parse(Console.ReadLine());
        //    if (a > b)
        //    {
        //        int max = a;
        //        a = b;
        //        b = max;
        //    }
        //    if (b > c)
        //    {
        //        int max = b;
        //        b =c ;
        //        c = max;
        //    }
        //    if (a > b)
        //    {
        //        int max = a;
        //        a = b;
        //        b = max;
        //    }
        //    Console.WriteLine("Числа в порядке возрастания: {0}, {1}, {2}", a, b, c);
        //}

        //Задача 3. Создать метод, который будет вычислять площадь круга и длину окружности.
        //Вызывающий программный код должен передавать в качестве аргумента методу значение радиуса и печатать значение радиуса, площади круга и длины окружности.
        // public static void Round(int x)
        //{
        //    Console.WriteLine("Площадь круга="+3.14*Math.Pow(x, 2));
        //    Console.Write("Длина окружности="+3.14*2*x);

        //}
        //static void Main()
        //{
        //    Console.Write("Введите радиус=");
        //    int x = int.Parse(Console.ReadLine());
        //    Round(x);
        //}

        //Задача 4. Даны два предложения.Найти общее количество букв "н" в них. (Определить функцию для расчета количества букв н в предложении.)
        //static int FindN(string sentence)
        //{
        //    int y = 0;
        //    foreach (char c in sentence)
        //    {
        //        if (Char.ToLower(c) == 'н')
        //            y++;
        //    }
        //    return y;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите первое предложение:");
        //    string sentence1 = Console.ReadLine();

        //    Console.WriteLine("Введите второе предложение:");
        //    string sentence2 = Console.ReadLine();

        //    int a = FindN(sentence1);
        //    int b = FindN(sentence2);
        //    int x = a +b;

        //    Console.WriteLine("Общее количество букв 'н' в предложениях: " + x);
        //}







    }
}
