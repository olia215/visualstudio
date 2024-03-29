﻿using ConsoleApp45;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> people = new List<Person>();


        people.Add(new Applicant("John", "Doe", new DateTime(2000, 7, 15), "Engineering"));
        people.Add(new Student("Alice", "Smith", new DateTime(1998, 3, 20), "Physics", 3));
        people.Add(new Teacher("Bob", "Johnson", new DateTime(1985, 9, 10), "Mathematics", "Professor", 10));

        foreach (Person person in people)
        {
            person.Info();
        }

        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Введите название");
            string s = Console.ReadLine();
            switch (s)
            {
                case "Абитуриент":
                    people.Add(Applicant.Input());
                    break;
                case "Студент":
                    people.Add(Student.Input());
                    break;
                case "Учитель":
                    people.Add(Teacher.Input());
                    break;
            }

            foreach (var elem in people)
            {
                elem.Info();
            }

        }


        Console.Write("Введите нижнюю границу");
        int minAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите верхнюю границу");
        int maxAge = Convert.ToInt32(Console.ReadLine()); ;

        Console.WriteLine($"\nPeople aged between {minAge} and {maxAge} years:");
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Age() > minAge && list[i].Age() < maxAge) ;
        }
        foreach (Person person in people)
        {
            if (person.Age() >= minAge && person.Age() <= maxAge)
            {
                person.Info();
            }
        }

        Console.ReadKey();
    }
}
