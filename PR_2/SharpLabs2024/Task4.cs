using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024
{
    public class Task4 : ITaskable
    {
        private void FillArr(int[] Arr)
        {
            ConsoleColor originalColor = Console.ForegroundColor;

            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write($"Enter int element X[{i+1}]: ");

                while (!int.TryParse(Console.ReadLine(), out Arr[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Please enter a valid int element X[{i}]: ");
                    Console.ForegroundColor = originalColor;
                    Console.Write($"Enter int element X[{i+1}]: ");
                }
            }

        }

        private void PrintArr(int[] Arr)
        {
            ConsoleColor originalColor = Console.ForegroundColor;

            if ( Arr.Length == 0 )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Empty");
                Console.ForegroundColor = originalColor;
            }

            for (int i = 1; i < Arr.Length+1; i++)
            {
                Console.Write($"Element: X[{i}]: {Arr[i-1]}\t");
                if (i % 4 == 0)
                {
                    Console.WriteLine("");
                }

            }
        }

        private int GetNumM()
        {
            int M = 0;

            ConsoleColor originalColor = Console.ForegroundColor;

            Console.Write($"Enter int num M: ");

            while (!int.TryParse(Console.ReadLine(), out M))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Please enter a valid int num M");
                Console.ForegroundColor = originalColor;
                Console.Write($"Enter int num M: ");
            }

            return M;
        }


        public void Run()
        {
            Console.WriteLine("Task4\n");
                        
            int arrSize = 0 + 4;

            int[] X = new int[arrSize];

            FillArr(X);

            Console.WriteLine("");

            int M = GetNumM();

            int[] Y = new int[0];

            foreach (var i in X)
            {
                if (M < MathF.Abs(i))
                {
                    Array.Resize(ref Y, Y.Length + 1);
                    Y[Y.Length - 1] = i;

                }
            }
            
            Console.WriteLine($"\nM = {M}");

            Console.WriteLine($"\nStart Arr");

            PrintArr(X);

            Console.WriteLine($"\nFinish Arr");

            PrintArr(Y);

            Console.WriteLine();
        }
    }

}
