using ConsoleApp71;

internal class Program
{
    private static void Main(string[] args)
    {
        // Примеры работы с классом Segment для типов int, long и double

        // Отрезок с типом int
        Segment<int> intSegment = new Segment<int>(1, 2, 4, 6);
        Console.WriteLine("сегмент <int>:");
        intSegment.PrintInfo();
        Console.WriteLine($"Длина: {intSegment.GetLength()}");

        // Отрезок с типом long
        Segment<long> longSegment = new Segment<long>(1000000000L, 2000000000L, 4000000000L, 6000000000L);
        Console.WriteLine("\nсегмент <long>:");
        longSegment.PrintInfo();
        Console.WriteLine($"Длина: {longSegment.GetLength()}");

        // Отрезок с типом double
        Segment<double> doubleSegment = new Segment<double>(1.1, 2.2, 4.4, 6.6);
        Console.WriteLine("\nсегмент <double>:");
        doubleSegment.PrintInfo();
        Console.WriteLine($"Длина: {doubleSegment.GetLength()}");

        Console.ReadLine();
    }
}