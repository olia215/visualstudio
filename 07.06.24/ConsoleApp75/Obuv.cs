using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp75
{
    internal class Obuv : Tovar
    {
        public int Quantity { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        public Obuv(string name, decimal price, int quantity, string size, string color)
            : base(name, price)
        {
            Quantity = quantity;
            Size = size;
            Color = color;
        }

        public override decimal CalcSum()
        {
            return Price * Quantity;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество: {Quantity}");
            Console.WriteLine($"Размер: {Size}");
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Общая стоимость: {CalcSum():C}");
        }
    }
}
