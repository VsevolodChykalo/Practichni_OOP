namespace CSharpLabs2024.Task1
{
    internal class Author
    {
        private string? name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Author: " + name);
            Console.ResetColor();
        }
    }
}