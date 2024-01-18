using ConsoleApp32;

internal class Program
{
    private static void Main(string[] args)
    {
        MyClass myClass1 = new MyClass();

        Console.WriteLine("количества созданных экземпляров: " + MyClass.count);


        myClass1.Print();
        Console.ReadKey();

    }
}