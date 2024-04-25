using ConsoleApp60;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = 3; // Количество фигур

        Figure[] figures = new Figure[n]; // Создаем массив фигур

        figures[0] = new Rectangle(3, 4); // Прямоугольник
        figures[1] = new Circle(2); // Круг
        figures[2] = new Triangle(3, 4, 5); // Треугольник

        foreach (Figure fig in figures)
        {
            fig.PrintInfo(); // Выводим информацию о каждой фигуре
        }
    }
}