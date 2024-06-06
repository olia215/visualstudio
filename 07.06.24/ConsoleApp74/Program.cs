using ConsoleApp74;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание экземпляров транспортных средств
        Plane plane = new Plane(10, 20, 1000000, 900, 2018, 10000, 150);
        Car car = new Car(30, 40, 20000, 180, 2020);
        Ship ship = new Ship(50, 60, 500000, 80, 2015, 300, "Нью-Йорк");

        // Вывод информации о транспортных средствах
        Console.WriteLine("Самолет:");
        plane.ShowInfo();
        Console.WriteLine();

        Console.WriteLine("Машина:");
        car.ShowInfo();
        Console.WriteLine();

        Console.WriteLine("Корабль:");
        ship.ShowInfo();
        Console.WriteLine();
    }
}