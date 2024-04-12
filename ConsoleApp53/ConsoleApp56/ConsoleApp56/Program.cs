using ConsoleApp56;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***Изучение интерфейсов. Пример - 3***\n");
        MyClass myCkassOb = new MyClass();
        myCkassOb.ShowA();
        myCkassOb.ShowB();
        Console.ReadKey();
    }
}