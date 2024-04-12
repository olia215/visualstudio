using ConsoleApp53;

internal class Program
{
    private static void Main(string[] args)
    {
        // Пример использования классов
        Triangle triangle = new Triangle(3, 4, 5);
        Console.WriteLine("Площадь треугольника: " + triangle.CalculateArea());
        Console.WriteLine("Tтреугольник Периметр: " + triangle.CalculatePerimeter());

        Rectangle rectangle = new Rectangle(4, 5);
        Console.WriteLine("Площадь прямоугольника: " + rectangle.CalculateArea());
        Console.WriteLine("Периметр прямоугольника: " + rectangle.CalculatePerimeter());
    }
}