using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{/// <summary>
///  Интерфейс для геометрических фигур
/// </summary>
    internal interface figures
    {
        double CalculateArea(); // метод возвращающий площадь
        double CalculatePerimeter(); // метод возвращающий периметр
    }
}
