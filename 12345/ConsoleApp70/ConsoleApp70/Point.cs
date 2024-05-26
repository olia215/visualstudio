﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    internal class Point<T>
    {
        // Внутренние поля
        private T x;
        private T y;

        // Конструктор с 2 параметрами
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        // Свойства доступа к внутренним полям класса
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        // Метод, выводящий значения внутренних полей класса
        public void PrintCoordinates()
        {
            Console.WriteLine($"X: {x}, Y: {y}");
        }
    }
}
