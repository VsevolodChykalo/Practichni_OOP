using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024
{
    public class Task2:ITaskable
    {
        private double GetTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private double GetTrianglePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        private string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            if (a != b && b != c && a != c)
            {
                return "Scalene";
            }
            return "Isosceles";
        }

        private double GetTriangleSide(string sideName)
        {
            ConsoleColor originalColor = Console.ForegroundColor;

            double side;
            Console.Write($"Side {sideName}: ");
            while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Please enter a valid positive number for side {sideName}:");
                Console.ForegroundColor = originalColor;
                Console.Write($"Side {sideName}: ");
            }
            return side;
        }

        private bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public void Run()
        {
            Console.WriteLine("Task2\n");

            double a, b, c;

            a = GetTriangleSide("a");
            b = GetTriangleSide("b");
            c = GetTriangleSide("c");

            if (IsTriangleValid(a, b, c))
            {
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Triangle is not valid.");
                return;
            }


            Console.WriteLine($"Triangle type: {GetTriangleType(a, b, c)}, Perimeter: {GetTrianglePerimeter(a, b, c)}, Area: {GetTriangleArea(a, b, c)}");
        }
    }

}
