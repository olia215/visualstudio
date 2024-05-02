using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    internal class Point<T>
    {
        // Внутренние поля x и y
        private T x;
        private T y;

        // Конструктор с двумя параметрами для инициализации x и y
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        // Свойство для доступа к полю x
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        // Свойство для доступа к полю y
        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        // Метод для вывода значений внутренних полей x и y
        public void Print()
        {
            Console.WriteLine($"Координаты точки: ({x}, {y})");
        }
    }
}
