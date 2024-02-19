using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{ /// <summary>
  /// производные классы
  /// </summary>
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("открыть XML документ");
        }

        public override void Create()
        {
            Console.WriteLine("создать XML документ");
        }

        public override void Change()
        {
            Console.WriteLine("изменить XML документ");
        }

        public override void Save()
        {
            Console.WriteLine("сохранить XML документ");
        }

    }
}
