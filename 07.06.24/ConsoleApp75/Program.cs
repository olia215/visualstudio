using ConsoleApp75;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание экземпляров товаров
        Obuv shoes = new Obuv("Кроссовки", 50.99m, 2, "42", "Черные");
        Odejda shirt = new Odejda("Футболка", 19.99m, 3, "L", "Белый");
        Posuda plate = new Posuda("Тарелка", 5.50m, 10, 0.3);

        // Вывод информации о товарах
        Console.WriteLine("Обувь:");
        shoes.Print();
        Console.WriteLine();

        Console.WriteLine("Одежда:");
        shirt.Print();
        Console.WriteLine();

        Console.WriteLine("Посуда:");
        plate.Print();
        Console.WriteLine();
    }
}