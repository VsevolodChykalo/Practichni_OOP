using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024
{
    public class Task1:ITaskable
    {
        private void Is_number_in_range(int num, int start = 1, int end = 14)
        {
            if (num >= start && num <= end)
            {
                Console.WriteLine($"{num} in range");
                return;
            }

            Console.WriteLine($"{num} not in range");
        }

        public void Run()
        {
            Console.WriteLine("Task1\n");

            int number1, number2, number3;

            Console.Write("Num 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Num 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Num 3: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write('\n');

            Is_number_in_range(number1);
            Is_number_in_range(number2);
            Is_number_in_range(number3);
        }
    }
}
