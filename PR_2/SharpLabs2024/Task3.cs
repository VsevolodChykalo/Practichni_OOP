using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024
{
    public class Task3 : ITaskable
    {
        private int GetMininArr(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        private int GetMaxinArr(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        private void FillIntArr(int[] arr)
        {

            ConsoleColor originalColor = Console.ForegroundColor;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter int element X[{i}]: ");

                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Please enter a valid int element X[{i}]: ");
                    Console.ForegroundColor = originalColor;
                    Console.Write($"Enter int element X[{i}]: ");
                }
            }

        }


        public void Run()
        {
            Console.WriteLine("Task3\n");

            int arrSize = 0 + 4;

            int[] X = new int[arrSize];

            FillIntArr(X);
          
            Console.Write($"\nMax element in arr {GetMaxinArr(X)}, min {GetMininArr(X)}");


        }
    }

}
