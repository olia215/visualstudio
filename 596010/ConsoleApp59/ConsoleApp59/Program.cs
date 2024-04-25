using ConsoleApp59;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание списка автомобилей
        List<Car> cars = new List<Car>
            {
                // Добавление объектов Car в список
                new Car { Id = 1, Brand = "Toyota", MaxSpeed = 180, Price = 25000, Discount = 5 },
                new Car { Id = 2, Brand = "BMW", MaxSpeed = 220, Price = 40000, Discount = 10 },
                new Car { Id = 3, Brand = "Audi", MaxSpeed = 200, Price = 35000, Discount = 8 },
                new Car { Id = 4, Brand = "Mercedes", MaxSpeed = 210, Price = 38000, Discount = 12 },
                new Car { Id = 5, Brand = "Ford", MaxSpeed = 190, Price = 30000, Discount = 6 }
            };

        // Сортировка списка автомобилей по цене
        cars.Sort();

        // Вывод отсортированного списка автомобилей на экран
        Console.WriteLine("Сортировка машин по цене:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}