using ConsoleApp63;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание объекта класса Calculator с типом int
        Calculator<int> intCalculator = new Calculator<int>();

        // Выполнение математических операций с целыми числами
        Console.WriteLine("Сложение: " + intCalculator.Add(5, 3));
        Console.WriteLine("Вычитание: " + intCalculator.Subtract(5, 3));
        Console.WriteLine("Умножение: " + intCalculator.Multiply(5, 3));
        Console.WriteLine("Деление: " + intCalculator.Divide(10, 2));

        Console.WriteLine();

        // Создание объекта класса Calculator с типом double
        Calculator<double> doubleCalculator = new Calculator<double>();

        // Выполнение математических операций с числами с плавающей запятой
        Console.WriteLine("Сложение: " + doubleCalculator.Add(4.5, 2.5));
        Console.WriteLine("Вычитание: " + doubleCalculator.Subtract(4.5, 2.5));
        Console.WriteLine("Умножение: " + doubleCalculator.Multiply(4.5, 2.5));
        Console.WriteLine("Деление: " + doubleCalculator.Divide(9.0, 2.0));
    }
}