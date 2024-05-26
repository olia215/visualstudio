using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{/// <summary>
///  Класс Add, реализующий интерфейс ICalculation
/// </summary>
    internal class Add : ICalculation
    {
        private double _valueToAdd;

        public Add(double valueToAdd)
        {
            _valueToAdd = valueToAdd;
        }

        public double Perform(double number)
        {
            return number + _valueToAdd;
        }
    }
}
