using ConsoleApp72;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание экземпляров классов Add и Multiply
        ICalculation add = new Add(5);         // Увеличить на 5
        ICalculation multiply = new Multiply(3); // Умножить на 3

        // Применение преобразований к числу
        double number = 10;
        double result = Calculate(number, add, multiply);

        // Вывод результата
        Console.WriteLine($"Начальный номер: {number}");
        Console.WriteLine($"После сложения и умножения: {result}");

        Console.ReadLine();
    }

    // Метод Calculate, принимающий число и два преобразования
    static double Calculate(double number, ICalculation transformation1, ICalculation transformation2)
    {
        double result = transformation1.Perform(number);
        result = transformation2.Perform(result);
        return result;
    }
}