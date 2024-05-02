using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    internal class Calculator<T>
    {
       
        // Метод для сложения двух значений типа T
        public T Add(T a, T b)
        {
            dynamic sum = (dynamic)a + (dynamic)b; // Приведение типов к dynamic перед выполнением операции
            return sum;
        }

        // Метод для вычитания двух значений типа T
        public T Subtract(T a, T b)
        {
            dynamic difference = (dynamic)a - (dynamic)b;
            return difference;
        }

        // Метод для умножения двух значений типа T
        public T Multiply(T a, T b)
        {
            dynamic product = (dynamic)a * (dynamic)b;
            return product;
        }

        // Метод для деления двух значений типа T
        public T Divide(T a, T b)
        {
            dynamic quotient = (dynamic)a / (dynamic)b;
            return quotient;
        }
    }
}
