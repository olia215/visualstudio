using ConsoleApp72;

internal class Program
{//1
 //enum Months
 //{
 //    Январь = 0,
 //    Февраль = 1,
 //    Март = 2,
 //    Апрель = 3,
 //    Май = 4,
 //    Июнь = 5,
 //    Июль = 6,
 //    Август = 7,
 //    Сентябрь = 8,
 //    Октябрь = 9,
 //    Ноябрь = 10,
 //    Декабрь = 11
 //}

    //2
    //enum DaysOfWeek
    //{
    //    Sat = 0,
    //    Sun = 1,
    //    Mon = 2,
    //    Tue = 3,
    //    Wed = 4,
    //    Thu = 5,
    //    Fri = 6
    //}

    //3
    //enum MathOperation
    //{
    //    Add,
    //    Subtract,
    //    Multiply,
    //    Divide
    //}

    //4
    //enum UserRole
    //{
    //    Администратор,
    //    Модератор,
    //    Пользователь,
    //    Гость
    //}

    //5
    //public enum Post
    //{
    //    Manager = 160,    // Менеджер
    //    Developer = 180,  // Разработчик
    //    Designer = 150,   // Дизайнер
    //    Analyst = 170     // Аналитик
    //}
    private static void Main(string[] args)
    {//1
     //for (int i = 0; i <= 11; i++)
     //{
     //    Console.WriteLine($"{i} - {Enum.GetName(typeof(Months), i)}");
     //}


        //2
        //foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        //{
        //    Console.WriteLine($"{day} имеет значение {(int)day}");
        //}

        //3
        // Ввод двух вещественных чисел
        //Console.Write("Введите первое число: ");
        //double num1 = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Введите второе число: ");
        //double num2 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Выберите математическое действие (0 - Сложение, 1 - Вычитание, 2 - Умножение, 3 - Деление):");
        //int choice = Convert.ToInt32(Console.ReadLine());

        //MathOperation selectedOperation = (MathOperation)choice;

        //double result = 0;

        //switch (selectedOperation)
        //{
        //    case MathOperation.Add:
        //        result = num1 + num2;
        //        break;
        //    case MathOperation.Subtract:
        //        result = num1 - num2;
        //        break;
        //    case MathOperation.Multiply:
        //        result = num1 * num2;
        //        break;
        //    case MathOperation.Divide:
        //        result = num1 / num2;
        //        break;
        //    default:
        //        Console.WriteLine("Неправильный выбор.");
        //        break;
        //}

        //Console.WriteLine("Результат: " + result);


        //4
        //Console.WriteLine("Введите вашу роль (Администратор, Модератор, Пользователь, Гость): ");
        //string userInput = Console.ReadLine();

        //try
        //{
        //    UserRole role = (UserRole)Enum.Parse(typeof(UserRole), userInput, true);

        //    string roleMessage = role switch
        //    {
        //        UserRole.Администратор => "Вы зарегистрированы как администратор.",
        //        UserRole.Модератор => "Вы зарегистрированы как модератор.",
        //        UserRole.Пользователь => "Вы зарегистрированы как пользователь.",
        //        UserRole.Гость => "Вы зарегистрированы как гость.",
        //        _ => throw new ArgumentException("Некорректная роль.")
        //    };

        //    Console.WriteLine(roleMessage);
        //}
        //catch (ArgumentException)
        //{
        //    Console.WriteLine("Ошибка: введена некорректная роль.");
        //}

        //5
        //Console.WriteLine("Введите должность сотрудника (Manager, Developer, Designer, Analyst): ");
        //string postInput = Console.ReadLine();

        //Console.WriteLine("Введите количество отработанных часов в месяц: ");
        //int hoursWorked = Convert.ToInt32(Console.ReadLine());

        //try
        //{
        //    Post post = (Post)Enum.Parse(typeof(Post), postInput, true);

        //    Accountant accountant = new Accountant();
        //    bool isBonusGranted = accountant.AskForBonus(post, hoursWorked);

        //    if (isBonusGranted)
        //    {
        //        Console.WriteLine("Сотруднику положена премия.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Сотруднику не положена премия.");
        //    }
        //}
        //catch (ArgumentException)
        //{
        //    Console.WriteLine("Ошибка: введена некорректная должность.");
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("Ошибка: введено некорректное количество часов.");
        //}
    }
}
   
