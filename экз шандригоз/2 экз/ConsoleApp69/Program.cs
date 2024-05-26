using ConsoleApp69;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание объекта книги
        Book book = new Book("Война и мир", "Лев Толстой", "Эпический роман, описывающий события во времена войн Наполеона.");

        // Вывод на экран информации о книге
        book.Show();

        Console.ReadLine();
    }
}