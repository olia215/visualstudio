using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{/// <summary>
///  Класс Multiply, реализующий интерфейс ICalculation
/// </summary>
    internal class Multiply : ICalculation
    {
        private double _factor;

        public Multiply(double factor)
        {
            _factor = factor;
        }

        public double Perform(double number)
        {
            return number * _factor;
        }
    }
}
