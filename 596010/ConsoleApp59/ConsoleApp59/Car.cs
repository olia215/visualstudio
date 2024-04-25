using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{// Класс, представляющий автомобиль и реализующий интерфейс IComparable<Car>
    internal class Car : IComparable<Car>
    {// Свойства автомобиля
        public int Id { get; set; }            // Идентификатор
        public string Brand { get; set; }      // Марка
        public int MaxSpeed { get; set; }      // Максимальная скорость
        public double Price { get; set; }      // Цена
        public double Discount { get; set; }   // Скидка в %


        // Вычисляемое свойство, возвращает цену с учетом скидки
        public double DiscountedPrice => Price * (1 - Discount / 100);

        // Метод сравнения автомобилей по их цене
        public int CompareTo(Car other)
        {
            if (other == null) return 1;            // Проверка на null
            return Price.CompareTo(other.Price);   // Сравнение цен
        }

        //  метод ToString() для вывода информации об автомобиле
        public override string ToString()
        {
            return $"Идентификатор: {Id}, Марка: {Brand}, Максимальная скорость {MaxSpeed}, Цена: {DiscountedPrice}";
        }
    }
}
