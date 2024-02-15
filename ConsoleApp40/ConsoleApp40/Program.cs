using ConsoleApp40;

internal class Program
{
    private static void Main(string[] args)
    {
        Engineer engineer = new Engineer("Smith", "John", 1000, 1.2m, 15);
        engineer.DisplayInfo();

        Console.WriteLine();

        TouristBus touristBus = new TouristBus("Mercedes", 50, 10, 100);
        touristBus.DisplayInfo();

        Console.ReadLine();
    }
}