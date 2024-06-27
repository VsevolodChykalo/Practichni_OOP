namespace CSharpLabs2024.Task2
{
    internal class Point(int x, int y, string name)
    {
        public int X { get; } = x;
        public int Y { get; } = y;
        public string Name { get; } = name;
    }
}