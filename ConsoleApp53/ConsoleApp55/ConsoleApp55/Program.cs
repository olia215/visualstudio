using ConsoleApp55;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***Изучение интерфейсов. пример -2 ***\n");
        MyClass myOb = new ChildClass();
        myOb.Show1();
        myOb.Show2();
        Console.ReadKey();

    }
}