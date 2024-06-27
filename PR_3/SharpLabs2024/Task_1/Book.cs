using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024.Task1
{
    internal class Book
    {
        private readonly Title title;
        private Author author;
        private Content content;

        public Book(string bookTitle)
        {
            title = new Title(bookTitle);
            author = new Author();
            content = new Content();
        }

        public string Author
        {
            get { return author.Name; }
            set { author.Name = value; }
        }

        public string Content
        {
            get { return content.Text; }
            set { content.Text = value; }
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }

}
