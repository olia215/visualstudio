using ConsoleApp58;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***Изучение интерфейсов. пример -5 ***");
        Console.WriteLine("***Concept of multiple interitance through interface***");
        MyClass myClassOb = new MyClass();
        InterfaceA obA = myClassOb;
        obA.ShowInterfaceA();
        InterfaceB obB = myClassOb;
        obB.ShowInterfaceB();
        InterfaceC obC = myClassOb;
        obC.ShowInterfaceC();
        Console.ReadKey();

    }
}