using ConsoleApp72;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание экземпляров фигур
        Triangle triangle = new Triangle(3, 4, 5);
        Disk disk = new Disk(5);

        // Вывод информации о фигурах
        PrintShapeInfo(triangle);
        PrintShapeInfo(disk);

        Console.ReadLine();
    }

    // Метод для вывода информации о фигуре
    static void PrintShapeInfo(IShape shape)
    {
        if (shape is Triangle triangle)
        {
            Console.WriteLine("Форма: Треугольник");
            Console.WriteLine($"Сторонa: А = {triangle.A}, B = {triangle.B}, C = {triangle.C}");
        }
        else if (shape is Disk disk)
        {
            Console.WriteLine("Форма: Диск");
            Console.WriteLine($"Радиус = {disk.Radius}");
        }

        Console.WriteLine($"Периметр: {shape.Perimeter()}");
        Console.WriteLine($"Площадь: {shape.Area()}");
        Console.WriteLine();
    }
}