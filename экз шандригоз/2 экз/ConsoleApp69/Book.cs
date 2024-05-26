using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }

        // Метод для вывода всей информации о книге
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
