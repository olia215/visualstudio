using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
   
        /// <summary>

        /// абстрактный класс

        /// </summary>

        abstract class AClass

    { /// <summary>

      /// метод

      /// </summary>

        public void Method1()

        {

            Console.WriteLine("Об. м. Method1 из а.к. AClass ");

        }

        /// <summary>

        /// виртуальный метод

        /// </summary>

        public virtual void Method2()

        {

            Console.WriteLine("В. м. Method2 из а.к. AClass ");

        }

        public abstract void Method3();

        public abstract void Method4();



    }



}
