using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{/// <summary>
/// Описать класс счетчика посещения сайта
/// </summary>
    //internal class Website
    //{/// <summary>
    // ///  поле адрес открытой web-странички
    // /// </summary>
    //    public string WebPage { get; set; }
    //    /// <summary>
    //    /// поле ip-адрес посетителя
    //    /// </summary>
    //    public string IPAddress { get; set; }
    //    /// <summary>
    //    /// поле web-браузер посетителя
    //    /// </summary>
    //    public string WebBrowser { get; set; }
    //    /// <summary>
    //    /// поле дата визита
    //    /// </summary>
    //    public DateTime VisitDate { get; set; }
    //    /// <summary>
    //    /// поле время визита
    //    /// </summary>
    //    public TimeSpan VisitTime { get; set; }

    //    /// <summary>
    //    /// выводит информацию о всех посещениях сайта с указанием дня посещения
    //    /// </summary>
    //    /// <param name="visits"></param>
    //    public static void Site(Website[] visits)
    //    {
    //        Console.WriteLine("Посещения по дням:");
    //        foreach (var visit in visits)
    //        {
    //            string dayOfWeek = visit.VisitDate.ToString("dddd");
    //            Console.WriteLine($"Web страница: {visit.WebPage}, Дата посещения: {dayOfWeek}");
    //        }
    //    }
    //    /// <summary>
    //    /// выводит информацию о посещениях веб-страницы 'indexphp' в указанном временном интервале
    //    /// </summary>
    //    /// <param name="visits"></param>
    //    /// <param name="startTime"></param>
    //    /// <param name="endTime"></param>
    //    /// <param name="targetDate"></param>
    //    public static void Site1(Website[] visits, TimeSpan startTime, TimeSpan endTime, DateTime targetDate)
    //    {
    //        Console.WriteLine($"Посещения веб-страницы indexphp между\n{startTime.ToString(@"hh\:mm\:ss")} и {endTime.ToString(@"hh\:mm\:ss")} на {targetDate.ToString(@"dd\:MM\:yyyy")}:");
    //        foreach (var visit in visits)
    //        {
    //            if (visit.VisitDate.Date == targetDate.Date && visit.VisitTime >= startTime && visit.VisitTime <= endTime && visit.WebPage == "indexphp")
    //            {
    //                Console.WriteLine($"IP Address: {visit.IPAddress}, Web Browser: {visit.WebBrowser}");
    //            }
    //        }
    //    }
    //}
}
