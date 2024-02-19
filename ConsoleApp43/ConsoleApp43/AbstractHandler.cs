using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{/// <summary>
/// абстрактный класс
/// </summary>
    abstract internal class AbstractHandler
    {/// <summary>
     /// абстрактные методы
     /// </summary>
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
   
}
