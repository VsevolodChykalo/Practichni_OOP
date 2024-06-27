using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024.Task1
{
     internal class Task
    {
        public static void Run()
        {
            Console.WriteLine("Task1");

            Book book = new Book("C# Programming");
            book.Author = "Sasha Molodetc" ;
            book.Content = "This is text about Sasha" ;

            book.Show();

        }
    }
}
