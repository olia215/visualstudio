internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 1.Найти самое длинное слово из пяти введенных с клавиатуры.
        //string[] words = new string[5];
        //Console.WriteLine("Введите 5 слов:");
        //for (int i =0; i < words.Length; i++)
        //{
        //    words[i] = Console.ReadLine();
        //}
        //string k = words[0];
        //for (int i = 1; i < words.Length; i++)
        //{
        //    if (words[i].Length > k.Length)
        //    {
        //        k = words[i];
        //    }
        //}
        //Console.WriteLine("Введите самое длинное слово: " + k);

        //Задача 2.Составьте программу, удаляющую букву «е» («Е») из предложения.
        //Console.WriteLine("Введите предложение:");
        //string s = Console.ReadLine();
        //// Удаляем все символы 'е' и 'Е' из предложения
        //s=s.Replace("е", "").Replace("Е", "");
        //Console.WriteLine("Результат:");
        //Console.WriteLine(s);

        //Задача 3.Составьте программу вычисления количества букв «а» («А») в предложении.
        //Console.WriteLine("Введите предложение:");
        //string a = Console.ReadLine();
        //a = a.ToLower();
        //int count = 0;
        //for (int i = 0; i <a.Length; i++)
        //{
        //    if (a[i] == 'а')
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine("Количество букв 'а' в предложении: " + count);

        //Задача 4.Составьте программу, определяющую длину первого слова в предложении.
        //Console.WriteLine("Введите предложение:");
        //string с = Console.ReadLine();
        //string[] words = с.Split(' ');
        //if (words.Length > 1)
        //{
        //    string firstWord = words[0];
        //    int length = firstWord.Length;
        //    Console.WriteLine("Длина первого слова: " + length);
        //}
        //else
        //{
        //    Console.WriteLine("Предложение должно содержать хотя бы одно слово");
        //}

        //Задача 5.Составьте программу, определяющую длину последнего слова в предложении.
        //Console.WriteLine("Введите предложение:");
        //string sentence = Console.ReadLine();
        //string[] words = sentence.Split(' ');
        //if (words.Length > 0)
        //{
        //    string lastWord = words[words.Length - 1];
        //    int length = lastWord.Length;
        //    Console.WriteLine("Длина последнего слова: " + length);
        //}
        //else
        //{
        //    Console.WriteLine("Предложение должно содержать хотя бы одно слово");
        //}

        //Задача 6.Составьте программу, заменяющую букву «а» («А») на «о» («О») в предложении.
        //Console.WriteLine("Введите предложение:");
        //string b = Console.ReadLine();
        //b = b.Replace("а", "о");
        //b = b.Replace("А", "О");
        //Console.WriteLine("Результат:");
        //Console.WriteLine(b);

        //Задача 7.Написать программу для получения реверсированной строки.
        //Console.WriteLine("Введите строку:");
        //string s = Console.ReadLine();
        //char[] a = s.ToCharArray();
        //char[] b = new char[a.Length];
        //for (int i = 0; i < a.Length; i++)
        //{
        //    b[i] = a[a.Length - 1 - i];
        //}
        //string reversedString = new string(b);
        //Console.WriteLine("Реверсированная строка:");
        //Console.WriteLine(reversedString);

    }
}