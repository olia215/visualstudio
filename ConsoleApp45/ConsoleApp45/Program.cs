using ConsoleApp45;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> people = new List<Person>();


        people.Add(new Applicant("John", "Doe", new DateTime(2000, 7, 15), "Инженерный"));
        people.Add(new Student("Alice", "Smith", new DateTime(1998, 3, 20), "Физический", 3));
        people.Add(new Teacher("Bob", "Johnson", new DateTime(1985, 9, 10), "Математический", "Профессор", 10));

        foreach (Person person in people)
        {
            person.Info();
        }

        int minAge = 20;
        int maxAge = 30;

        Console.WriteLine($"\nЛюди в возрасте от {minAge} и до {maxAge} лет:");
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