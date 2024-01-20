using ConsoleApp33;

internal class Program
{
    private static void Main(string[] args)
    {
        //object[] arr = new object[6]; 
        //arr[0] = 1859; //arr[1] = -7; 
        //arr[2] = 'g'; //arr[3] = "hello"; 
        //arr[4] = null; //arr[5] = new object(); 
        //foreach (var point in arr) 
        //{ // Console.WriteLine($"{arr}"); 
        //} //Console.ReadKey(); 


        /// <summary>
        /// создаем массив
        /// </summary> 

        Students[] students = new Students[3];
        /// <summary>
        /// Ввод информации о школьниках
        /// </summary> 

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Информация о студентах: {i + 1}:");
            Console.Write("Фамилия: "); string fullName = Console.ReadLine();
            Console.Write("пол: "); string gender = Console.ReadLine();
            Console.Write("год рождения: "); int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine();
            students[i] = new Students(fullName, gender, birthYear);
        }

        int x = 0; int y = 0;
        /// <summary>
        /// Подсчет количества мальчиков и девочек 
        /// </summary> 

        foreach (var student in students)
        {
            if (student.Gender.ToLower() == "мужской")
            { x++; }
            else if (student.Gender.ToLower() == "женский")
            { y++; }
        }
        /// <summary>
        /// вывод каждого из списка
        /// </summary>
        Console.WriteLine($"количество мальчиков: {x}");
        Console.WriteLine($"количество девочек: {y}");
        Console.WriteLine("\nсписок мальчиков:");
        foreach (var student in students)
        {
            if (student.Gender.ToLower() == "мужчина")
            { Console.WriteLine(student.FullName); }
        }
        Console.WriteLine("\nсписок девочек:");
        foreach (var student in students)
        {
            if (student.Gender.ToLower() == "женщина")
            { Console.WriteLine(student.FullName); }
        }
        Console.ReadKey();
    }
} 

    
