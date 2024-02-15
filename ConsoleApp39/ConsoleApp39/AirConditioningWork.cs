using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    //internal class AirConditioningWork
    //{/// <summary>
    // ///  поле дата включения кондиционера
    // /// </summary>
    //    public DateTime StartDate { get; set; }
    //    /// <summary>
    //    /// поле время включения кондиционера
    //    /// </summary>
    //    public TimeSpan StartTime { get; set; }
    //    /// <summary>
    //    /// поле температурный режим (охлаждение, отопление и т.д.)
    //    /// </summary>
    //    public string TemperatureMode { get; set; }
    //    /// <summary>
    //    /// поле заданная температура воздуха
    //    /// </summary>
    //    /// 
    //    public int TargetTemperature { get; set; }
    //    /// <summary>
    //    ///  статический метод выводит информацию о запланированных режимах кондиционера с указанием количества оставшихся минут до начала работы
    //    /// </summary>
    //    /// <param name="works"></param>
    //    public static void Condition(List<AirConditioningWork> works)
    //    {
    //        Console.WriteLine("Запланированные режимы с оставшимися минутами:");
    //        foreach (var work in works)
    //        {
    //            DateTime now = DateTime.Now;
    //            DateTime scheduledDateTime = work.StartDate.Date + work.StartTime;
    //            TimeSpan remainingTime = scheduledDateTime - now;
    //            int remainingMinutes = (int)remainingTime.TotalMinutes;

    //            Console.WriteLine($"Температурный режим: {work.TemperatureMode}, Целевая температура: {work.TargetTemperature} °C, Оставшиеся минуты: {remainingMinutes}");
    //        }
    //    }
    //    /// <summary>
    //    /// статический метод выводит информацию о запланированных режимах кондиционера на следующий день
    //    /// </summary>
    //    /// <param name="works"></param>
    //    public static void Condition1(List<AirConditioningWork> works)
    //    {
    //        Console.WriteLine("Запланированные режимы на завтра:");
    //        foreach (var work in works)
    //        {
    //            if (work.StartDate.Date == DateTime.Today.AddDays(1))
    //            {
    //                Console.WriteLine($"Температурный режим: {work.TemperatureMode}, Целевая температура: {work.TargetTemperature} °C");
    //            }
    //        }
    //    }
    //}
}
