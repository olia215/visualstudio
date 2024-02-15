using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Bus
    {/// <summary>
     /// поля: марка
     /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// количество мест
        /// </summary>
        public int NumberOfSeats { get; set; }
        /// <summary>
        /// стоимость билета
        /// </summary>
        public decimal TicketPrice { get; set; }

        public Bus(string brand, int numberOfSeats, decimal ticketPrice)
        {
            Brand = brand;
            NumberOfSeats = numberOfSeats;
            TicketPrice = ticketPrice;
        }
        /// <summary>
        /// Метод: Общая стоимость всех мест
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalCost()
        {
            return NumberOfSeats * TicketPrice;
        }
        /// <summary>
        /// вывод
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"бренд: {Brand}");
            Console.WriteLine($"Количество мест: {NumberOfSeats}");
            Console.WriteLine($"Стоимость билета: {TicketPrice}");
            Console.WriteLine($"Общая стоимость: {GetTotalCost()}");
        }
    }
}

