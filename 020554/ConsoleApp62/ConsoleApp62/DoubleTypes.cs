using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    internal class DoubleTypes<T1, T2>
    {
        // Внутренние поля var1 и var2 соответствующих типов T1 и T2
        private T1 var1;
        private T2 var2;

        // Конструктор класса для инициализации полей var1 и var2
        public DoubleTypes(T1 value1, T2 value2)
        {
            var1 = value1;
            var2 = value2;
        }

        // Метод Print для вывода значений полей var1 и var2
        public void Print()
        {
            Console.WriteLine($"Value 1: {var1}");
            Console.WriteLine($"Value 2: {var2}");
        }
    }
}
