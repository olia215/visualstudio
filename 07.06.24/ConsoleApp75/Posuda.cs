using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp75
{
    internal class Posuda : Tovar
    {
        public int Quantity { get; set; }
        public double Weight { get; set; }

        public Posuda(string name, decimal price, int quantity, double weight)
            : base(name, price)
        {
            Quantity = quantity;
            Weight = weight;
        }

        public override decimal CalcSum()
        {
            return Price * Quantity;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество: {Quantity}");
            Console.WriteLine($"Масса: {Weight} kg");
            Console.WriteLine($"Общая стоимость: {CalcSum():C}");
        }
    }
}
