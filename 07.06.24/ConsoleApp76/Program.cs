using ConsoleApp76;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание экземпляров людей разных национальностей
        Person russian = new Russian("Иван");
        Person ukrainian = new Ukrainian("Олег");
        Person american = new American("John");
        Person turkish = new Turkish("Mehmet");

        // Вывод приветствий
        russian.SayGreeting();
        ukrainian.SayGreeting();
        american.SayGreeting();
        turkish.SayGreeting();
    }
}