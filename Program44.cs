internal class Program
{
    private static void Main(string[] args)
    {
        //Задание 1.Вывести сообщение с информацией о текущей системной дате, применив несколько форматов.
        //DateTime dateTime4 = DateTime.Now;
        //Console.WriteLine("Текущая дата:");
        //Console.WriteLine(dateTime4.ToString("d.MM.yyyy"));
        //Console.WriteLine(dateTime4.ToLongDateString());
        //Console.WriteLine(dateTime4.ToShortDateString());
        //Console.WriteLine($"{dateTime4:d}");
        //Console.WriteLine(dateTime4.ToString("d MMM yyyy"));
        //Console.WriteLine(dateTime4.ToString("d MMMM yyyy") + " г.");
        //Console.WriteLine(dateTime4.ToString("ddd, d MMM yyyy"));
        //Console.WriteLine(dateTime4.ToString("dddd, d MMMM yyyy"));

        //Console.WriteLine("Введите возраст:");
        //int age = Convert.ToInt32(Console.ReadLine());
        //int birthYear = DateTime.Now.Year - age;
        //Console.WriteLine("Ты родился в " + birthYear + " году");

        // Задание 2 Запросить с клавиатуры возраст человека и вывести на экран следующее сообщение: Ты родился в .... году
        //DateTime dt = DateTime.Now;
        //Console.WriteLine("Введите возраст:");
        //int age = Convert.ToInt32(Console.ReadLine());
        //int birthYear = DateTime.Now.Year - age;
        //Console.WriteLine("Ты родился в " + birthYear + " году");

        //    Задание 3.Определить возраст человека
        //    Console.Write("Введите дату своего рождения: ");
        //    string date= Console.ReadLine();
        //    //Преобразование строки в дату
        //    DateTime date1;
        //    if (!DateTime.TryParseExact(date, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date1))
        //    {
        //        Console.WriteLine("Некорректный формат даты.");
        //        return;
        //    }

        //    // Вычисление возраста
        //    int age = CalculateAge(date1);

        //    // Вывод возраста
        //    Console.WriteLine("Ваш возраст: " + age);
        //}

        //static int CalculateAge(DateTime date1)
        //{
        //    DateTime currentDate = DateTime.Now;

        //    int age = currentDate.Year - date1.Year;
        //    if (currentDate.Month < date1.Month || (currentDate.Month == date1.Month && currentDate.Day < date1.Day))
        //    {
        //        age--;
        //    }

        //    return age;
    }
}
