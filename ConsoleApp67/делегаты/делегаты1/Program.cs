using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        /// <summary>
        /// задание 1 
        /// </summary>
        delegate void GreetingDelegate();
       
            // Создание статических методов вывода сообщений
            static void SayGoodMorning()
            {
                Console.WriteLine("Доброе утро!");
            }

            static void SayGoodEvening()
            {
                Console.WriteLine("Добрый вечер!");
            }
        //метод
            static void Main(string[] args)
            {
                // Создание делегата
                GreetingDelegate greeting;

                // Применение делегата для вызова методов
                greeting = SayGoodMorning;
                greeting(); // Вызов метода "Доброе утро!"

                greeting = SayGoodEvening;
                greeting(); // Вызов метода "Добрый вечер!"

                Console.ReadKey();
            }


    }
}