using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    abstract internal class MyClass : IMyInterface
    {
        public void Show1()
        {
            Console.WriteLine("MyClass.Show1() is implemented.");
        }
        public abstract void Show2();
        
    }
}
