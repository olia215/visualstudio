using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    internal class Plane : Vehicle
    {
        public double Height { get; set; }
        public int Passengers { get; set; }

        public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
            : base(x, y, price, speed, year)
        {
            Height = height;
            Passengers = passengers;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Пассажиры: {Passengers}");
        }
    }
}
