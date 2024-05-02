using ConsoleApp64;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание объекта класса Point с типом int
        Point<int> intPoint = new Point<int>(5, 10);

        // Вывод значений x и y
        intPoint.Print();

        // Изменение значений x и y через свойства
        intPoint.X = 7;
        intPoint.Y = 15;

        // Вывод измененных значений x и y
        intPoint.Print();

        // Создание объекта класса Point с типом double
        Point<double> doublePoint = new Point<double>(2.5, 4.8);

        // Вывод значений x и y
        doublePoint.Print();
    }
}