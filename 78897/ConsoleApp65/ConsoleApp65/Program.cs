using ConsoleApp65;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание объекта класса Triangle с типом int
        Triangle<int> intTriangle = new Triangle<int>(3, 4, 5);

        // Вывод информации о треугольнике
        intTriangle.PrintInfo();

        // Вычисление и вывод площади треугольника
        Console.WriteLine($"Площадь треугольника: {intTriangle.CalculateArea()}");

        // Создание объекта класса Triangle с типом uint
        Triangle<uint> uintTriangle = new Triangle<uint>(2, 2, 3);

        // Вывод информации о треугольнике
        uintTriangle.PrintInfo();

        // Вычисление и вывод площади треугольника
        Console.WriteLine($"Площадь треугольника: {uintTriangle.CalculateArea()}");

        // Создание объекта класса Triangle с типом double
        Triangle<double> doubleTriangle = new Triangle<double>(4.2, 5.7, 7.1);

        // Вывод информации о треугольнике
        doubleTriangle.PrintInfo();

        // Вычисление и вывод площади треугольника
        Console.WriteLine($"Площадь треугольника: {doubleTriangle.CalculateArea()}");
    }
}