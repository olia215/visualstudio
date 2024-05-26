using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    internal class Segment<T> where T : struct, IConvertible
    {
        // Поля для координат точек
        private T x1;
        private T y1;
        private T x2;
        private T y2;

        // Конструктор с 4 параметрами
        public Segment(T x1, T y1, T x2, T y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        // Свойства доступа к координатам точек
        public T X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public T Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        public T X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public T Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        // Метод вывода информации об отрезке
        public void PrintInfo()
        {
            Console.WriteLine($"Конечные точки сегмента: ({x1}, {y1}), ({x2}, {y2})");
        }

        // Метод, возвращающий длину отрезка
        public double GetLength()
        {
            double dx1 = Convert.ToDouble(x1);
            double dy1 = Convert.ToDouble(y1);
            double dx2 = Convert.ToDouble(x2);
            double dy2 = Convert.ToDouble(y2);

            return Math.Sqrt(Math.Pow(dx2 - dx1, 2) + Math.Pow(dy2 - dy1, 2));
        }
    }
}
