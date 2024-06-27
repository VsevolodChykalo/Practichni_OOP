using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024.Task2
{
    internal class Task
    {
        public static void Run()
        {
            Console.WriteLine("Task2");

            Point A = new Point(0, 0, "A");
            Point B = new Point(3, 0, "B");

            //Figure line = new Figure(A, B);
            //line.PerimeterCalculator();

            Point C = new Point(3, 4, "C");

            Figure triangle = new Figure(A, B, C);
            triangle.PerimeterCalculator();

            Point D = new Point(0, 4, "D");
            Figure square = new Figure(A, B, C, D);
            square.PerimeterCalculator();

        }
    }
}
