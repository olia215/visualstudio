using ConsoleApp70;

internal class Program
{
    private static void Main(string[] args)
    {
        // Примеры работы с классом Point для типов int, uint и double

        // Точки с типом int
        Point<int> intPoint = new Point<int>(3, 4);
        Console.WriteLine("Point<int>:");
        intPoint.PrintCoordinates();

        // Точки с типом uint
        Point<uint> uintPoint = new Point<uint>(5, 6);
        Console.WriteLine("\nPoint<uint>:");
        uintPoint.PrintCoordinates();

        // Точки с типом double
        Point<double> doublePoint = new Point<double>(7.1, 8.2);
        Console.WriteLine("\nPoint<double>:");
        doublePoint.PrintCoordinates();

        Console.ReadLine();
    }
}