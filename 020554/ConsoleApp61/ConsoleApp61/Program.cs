using ConsoleApp61;

internal class Program
{
    private static void Main(string[] args)
    {
        // Задание значений параметров для каждого объекта
        int intPower = 500; // Мощность первого самолета типа int
        double floatPower = 650.5; // Мощность второго самолета типа double
        string strPower = "450"; // Мощность третьего самолета типа string

        // Создание трех объектов класса TransportCompany с использованием одного универсального параметра
        TransportCompany<int> plane1 = new TransportCompany<int>(intPower, 1000000.0, "Boeing"); // Создание объекта plane1 с типом мощности int
        TransportCompany<double> plane2 = new TransportCompany<double>(floatPower, 1500000.0, "Airbus"); // Создание объекта plane2 с типом мощности double
        TransportCompany<string> plane3 = new TransportCompany<string>(strPower, 800000.0, "Embraer"); // Создание объекта plane3 с типом мощности string
    }
}
