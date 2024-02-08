using ConsoleApp38;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. создать объект базового класса и обратиться к методу вывода состояния объекта базового класса;
        Person person = new Person { Name = "Настя", Age = 17, Surname = "Ткачук" };
        person.Print();

        //2.создать объект производного класса и обратиться к методу вывода информации о сотруднике производного класса;
        Employee employee = new Employee { Name = "Галина", Age = 14, Company = "Microsoft", Job = "менеджер" };
        employee.Print();

        //3.создать ссылку типа базового класса на объект производного класса и обратиться к методу вывода состояния объекта базового класса
        Person employeeAsPerson = new Employee { Name = "настя", Age = 18, Company = "Microsoft", Job = "повар" };
        employeeAsPerson.Print();

        //Создание объекта базового класса
        Notebook notebook = new Notebook("математика", 100);
        notebook.PrintInfo();
        Console.WriteLine($"расходы: {notebook.GetCost()} ");

        //Создание объекта производного класса
        ExerciseNotebook exerciseNotebook = new ExerciseNotebook("английскиий", 120, "мягкий");
        exerciseNotebook.PrintInfo();
        Console.WriteLine($"расходы: {exerciseNotebook.GetCost()} ");
        Console.ReadKey();
    }
}