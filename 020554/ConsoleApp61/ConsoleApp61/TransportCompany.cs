using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{/// <summary>
///  Создание универсального класса TransportCompany
/// </summary>
/// <typeparam name="T"></typeparam>
    internal class TransportCompany<T>
    {

        // Объявление свойств Power, Cost и Brand для хранения характеристик самолета
        public T Power { get; set; } // Свойство для хранения мощности самолета, тип параметра - универсальный
        public double Cost { get; set; } // Свойство для хранения стоимости самолета
        public string Brand { get; set; } // Свойство для хранения марки самолета

        // Конструктор класса TransportCompany для инициализации характеристик самолета
        public TransportCompany(T power, double cost, string brand)
        {
            Power = power; // Присваивание переданного значения мощности самолета свойству Power
            Cost = cost; // Присваивание переданного значения стоимости самолета свойству Cost
            Brand = brand; // Присваивание переданного значения марки самолета свойству Brand
        }

    }
}