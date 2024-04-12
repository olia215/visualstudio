using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class MyClass : IMyInterface
    {
       //класс, в котором реализуется интерфейс 
       public void Show()
        {
            Console.WriteLine("MyClass.Show() is implemented (реализован) .");
        }
    }
}
