using ConsoleApp31;

internal class Program
{
    private static void Main(string[] args)
    {
        //MyClass myClass = new MyClass();

        //MyClass instance1 = new MyClass();

        //MyClass instance2 = new MyClass();

        //MyClass instance3 = new MyClass();

        //MyClass instance4 = new MyClass();

        //MyClass.number = 10;

        //MyClass.number = 20;

        //MyClass.price = 30;



        //myClass.Print();

        //instance1.Print();

        //instance2.Print();

        //instance3.ID();

        //instance4.ID2();

        //Console.ReadKey();



        //Задача 2.
        //Point point1 = new Point(1, 1);
        //Point point2 = new Point(4, 5);
        //double d= Point.LengthPoints(point1, point2);
        //Console.WriteLine("расстояния между двумя точками " + d);


        //Задача 1
        Point point1 = new Point(3.0, 4.0);
        Point point2 = new Point();
        Point point3 = new Point(-2.5, 7.8);

        point1.Print();
        point2.Print();
        point3.Print();

        Console.WriteLine("Общее количество созданных экземпляров Point: " + Point.GetInstanceCount());

    }
}