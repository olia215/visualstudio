using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    internal class Point
    {
        // Поля для хранения координат и имени точки
        private int x;
        private int y;
        private string name;

        // Конструктор для инициализации полей
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        // Свойства для доступа к координатам и имени точки
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
