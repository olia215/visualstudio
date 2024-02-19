using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{/// <summary>
 /// производные классы
 /// </summary>
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine(" открыть DOC документ");
        }

        public override void Create()
        {
            Console.WriteLine("создать DOC документ");
        }

        public override void Change()
        {
            Console.WriteLine("изменить DOC документ");
        }

        public override void Save()
        {
            Console.WriteLine("сохранить DOC документ");
        }
    }
}
