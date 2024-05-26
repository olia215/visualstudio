using ConsoleApp69;

internal class Program
{
    private static void Main(string[] args)
    {
        // Треугольник с типом int
        Triangle<int> intTriangle = new Triangle<int>(3, 4, 5);
        Console.WriteLine("Треугольник <int>:");
        intTriangle.PrintInfo();
        Console.WriteLine($"Площадь: {intTriangle.GetArea()}");

        // Треугольник с типом uint
        Triangle<uint> uintTriangle = new Triangle<uint>(6, 8, 10);
        Console.WriteLine("\nТреугольник <uint>:");
        uintTriangle.PrintInfo();
        Console.WriteLine($"Площадь: {uintTriangle.GetArea()}");

        // Треугольник с типом double
        Triangle<double> doubleTriangle = new Triangle<double>(7.1, 8.2, 9.3);
        Console.WriteLine("\nТреугольник <double>:");
        doubleTriangle.PrintInfo();
        Console.WriteLine($"Площадь: {doubleTriangle.GetArea()}");

        Console.ReadLine();
    }
}