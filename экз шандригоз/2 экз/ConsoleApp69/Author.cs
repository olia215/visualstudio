using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    internal class Author
    {
        private string authorName;

        public Author(string authorName)
        {
            this.authorName = authorName;
        }

        // Метод для вывода имени автора
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green; // Устанавливаем цвет текста
            Console.WriteLine("Автор: " + authorName);
            Console.ResetColor(); // Сбрасываем цвет текста обратно на стандартный
        }
    }
}
