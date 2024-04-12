using ConsoleApp57;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***Изучение интерфейсов. Пример - 4 ***\n");
        MyClass myClassob = new MyClass();
        myClassob.Show();
        IMyInterfaceA interA = new MyClass();
        interA.Show();
        IMyInterfaceB interB = new MyClass();
        interB.Show();
        Console.ReadKey();


    }
}