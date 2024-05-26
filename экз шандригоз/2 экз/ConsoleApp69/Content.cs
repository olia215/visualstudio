using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    internal class Content
    {
        private string content;

        public Content(string content)
        {
            this.content = content;
        }

        // Метод для вывода содержания книги
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red; // Устанавливаем цвет текста
            Console.WriteLine("Содержание: ");
            Console.WriteLine(content);
            Console.ResetColor(); // Сбрасываем цвет текста обратно на стандартный
        }
    }
}
