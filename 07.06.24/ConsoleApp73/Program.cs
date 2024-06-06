using ConsoleApp73;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание экземпляров учеников
        Pupil pupil1 = new ExcelentPupil("Иванов");
        Pupil pupil2 = new GoodPupil("Петров");
        Pupil pupil3 = new BadPupil("Сидоров");

        // Создание учебного класса с учениками
        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);

        // Вывод информации о навыках учеников
        classRoom.ShowPupilsActivities();
    }
}