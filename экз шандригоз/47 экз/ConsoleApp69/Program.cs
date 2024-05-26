using ConsoleApp69;

internal class Program
{
    private static void Main(string[] args)
    {
        // Запрос длин сторон у пользователя
        Console.WriteLine("Введите длину первой стороны прямоугольника:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину второй стороны прямоугольника:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Создание экземпляра прямоугольника
        Rectangle rectangle = new Rectangle(side1, side2);

        // Вывод на экран площади и периметра прямоугольника
        Console.WriteLine("Площадь прямоугольника: " + rectangle.Area);
        Console.WriteLine("Периметр прямоугольника: " + rectangle.Perimeter);

        Console.ReadLine();
    }
}