using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    internal class Triangle<T> where T : struct, IConvertible
    {
        // Поля для сторон треугольника
        private T a;
        private T b;
        private T c;

        // Конструктор с 3 параметрами
        public Triangle(T a, T b, T c)
        {
            // Дополнительная логика для проверки корректности сторон треугольника
            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException(" стороны не образуют треугольник");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Свойства доступа к внутренним полям с дополнительной логикой
        public T A
        {
            get { return a; }
            set
            {
                if (!IsValidTriangle(value, b, c))
                {
                    throw new ArgumentException(" стороны не образуют треугольник");
                }
                a = value;
            }
        }

        public T B
        {
            get { return b; }
            set
            {
                if (!IsValidTriangle(a, value, c))
                {
                    throw new ArgumentException(" стороны не образуют треугольник");
                }
                b = value;
            }
        }

        public T C
        {
            get { return c; }
            set
            {
                if (!IsValidTriangle(a, b, value))
                {
                    throw new ArgumentException(" стороны не образуют треугольник");
                }
                c = value;
            }
        }

        // Метод вывода информации о треугольнике
        public void PrintInfo()
        {
            Console.WriteLine($"Стороны треугольника: a = {a}, b = {b}, c = {c}");
        }

        // Метод, возвращающий площадь треугольника
        public double GetArea()
        {
            double da = Convert.ToDouble(a);
            double db = Convert.ToDouble(b);
            double dc = Convert.ToDouble(c);

            double s = (da + db + dc) / 2;
            return Math.Sqrt(s * (s - da) * (s - db) * (s - dc));
        }

        // Метод проверки корректности треугольника
        private bool IsValidTriangle(T a, T b, T c)
        {
            double da = Convert.ToDouble(a);
            double db = Convert.ToDouble(b);
            double dc = Convert.ToDouble(c);

            return (da + db > dc) && (da + dc > db) && (db + dc > da);
        }
    }
}
