using ConsoleApp62;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание объекта класса DoubleTypes с типами int и string в качестве параметров
        DoubleTypes<int, string> dt = new DoubleTypes<int, string>(10, "информатика");

        // Вызов метода Print для вывода значений переменных
        dt.Print();
    }
}