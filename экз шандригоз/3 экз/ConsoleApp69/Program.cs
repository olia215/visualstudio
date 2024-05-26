using ConsoleApp69;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создаем точки для формирования многоугольника
        Point A = new Point(0, 0, "A");
        Point B = new Point(0, 4, "B");
        Point C = new Point(3, 4, "C");
        Point D = new Point(3, 0, "D");

        // Создаем многоугольник
        Figure figure = new Figure(A, B, C, D);

        // Вызываем метод для расчета периметра и вывода результата на экран
        figure.PerimeterCalculator();

        Console.ReadLine();
    }
}