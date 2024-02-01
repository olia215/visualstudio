using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class DateClass
    {/// <summary>
     /// поле DateTime data
     /// </summary>
        private DateTime data;
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public DateClass()
        {
            data = DateTime.Now;
        }
        /// <summary>
        ///  конструктор, позволяющий установить :заданную дату(конструктор с тремя параметрами – год, месяц, день)
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }
        /// <summary>
        /// свойство, позволяющее установить или получить значение поле класса(доступно для чтения и записи)
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        /// <summary>
        ///  методы, позволяющие: вычислить дату предыдущего дня; вычислить дату следующего дня; определить сколько дней осталось до конца месяца.
        /// </summary>
        /// <returns></returns>
        public DateTime GetPreviousDay()
        {
            return data.AddDays(-1);
        }

        public DateTime GetNextDay()
        {
            return data.AddDays(1);
        }

        public int GetDaysUntilEndOfMonth()
        {
            DateTime endOfMonth = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            return (endOfMonth - data).Days;
        }

    }
}
