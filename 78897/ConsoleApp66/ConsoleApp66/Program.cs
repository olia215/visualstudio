using ConsoleApp66;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание объекта класса Segment с типом int
        Segment<int> intSegment = new Segment<int>(0, 0, 3, 4);

        // Вывод информации об отрезке
        intSegment.PrintInfo();

        // Вычисление и вывод длины отрезка
        Console.WriteLine($"Длина сегмента: {intSegment.CalculateLength()}");

        // Создание объекта класса Segment с типом long
        Segment<long> longSegment = new Segment<long>(0, 0, 5, 12);

        // Вывод информации об отрезке
        longSegment.PrintInfo();

        // Вычисление и вывод длины отрезка
        Console.WriteLine($"Длина сегмента: {longSegment.CalculateLength()}");

        // Создание объекта класса Segment с типом double
        Segment<double> doubleSegment = new Segment<double>(1.5, 2.5, 4.5, 5.5);

        // Вывод информации об отрезке
        doubleSegment.PrintInfo();

        // Вычисление и вывод длины отрезка
        Console.WriteLine($"Длина сегмента: {doubleSegment.CalculateLength()}");
    }
}