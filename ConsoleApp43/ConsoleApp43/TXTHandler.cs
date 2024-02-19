using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{/// <summary>
 /// производные классы
 /// </summary>
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine(" открыть TXT документ");
        }

        public override void Create()
        {
            Console.WriteLine("создать TXT документ");
        }

        public override void Change()
        {
            Console.WriteLine("изменить TXT документ");
        }

        public override void Save()
        {
            Console.WriteLine("сохранить TXT документ");
        }
    }
}
