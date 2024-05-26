using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    internal class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        // Метод для вывода названия книги
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue; // Устанавливаем цвет текста
            Console.WriteLine("Название книги: " + title);
            Console.ResetColor(); // Сбрасываем цвет текста обратно на стандартный
        }
    }
}
