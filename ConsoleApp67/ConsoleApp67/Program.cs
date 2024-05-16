internal class Program
{
    delegate int SumDelegate(int m, int n);
    private static void Main(string[] args)
    {
        // Применяем делегат SumDelegate три раза
        SumDelegate sumDelegate = Sum;

        int result1 = sumDelegate(1, 5);
        Console.WriteLine("Сумма от 1 до 5: " + result1);

        int result2 = sumDelegate(10, 20);
        Console.WriteLine("Сумма от 10 до 20: " + result2);

        int result3 = sumDelegate(30, 40);
        Console.WriteLine("Сумма от 30 до 40: " + result3);

        Console.ReadLine();
    }

    static int Sum(int m, int n)
    {
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}