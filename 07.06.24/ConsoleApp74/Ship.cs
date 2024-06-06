using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    internal class Ship : Vehicle
    {
        public int Passengers { get; set; }
        public string Port { get; set; }

        public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Пассажиры: {Passengers}");
            Console.WriteLine($"Порт: {Port}");
        }
    }
}
