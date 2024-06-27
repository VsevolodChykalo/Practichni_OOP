namespace CSharpLabs2024.Task2
{
    internal class Figure
    {
        private readonly Point[] points;

        //// Constructor with variable quantity parameters

        //public Figure(params Point[] figurePoints)
        //{
        //    if (figurePoints == null || figurePoints.Length < 3 || figurePoints.Length > 5)
        //    {
        //        throw new ArgumentException("Invalid number of points. Figure must have 3 to 5 points.");
        //    }

        //    points = figurePoints;
        //}

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[3] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[4] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[5] { point1, point2, point3, point4, point5 };
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }

            perimeter += LengthSide(points[points.Length - 1], points[0]);

            Console.WriteLine($"Figure perimeter is {perimeter}");
        }
    }
}