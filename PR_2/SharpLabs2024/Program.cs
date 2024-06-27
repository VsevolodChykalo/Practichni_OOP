using System;

namespace CSharpLabs2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<ITaskable>
            {
                new Task1(),
                new Task2(),
                new Task3(),
                new Task4()
            };

            foreach (var task in tasks)
            {
                task.Run();
                Console.WriteLine("\n");
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("\n");
            }

            Console.WriteLine("Program completed.");
            Console.ReadKey();
        }
    }
}


