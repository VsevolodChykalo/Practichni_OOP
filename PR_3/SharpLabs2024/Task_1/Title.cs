namespace CSharpLabs2024.Task1
{
    internal class Title
    {
        private readonly string title;

        public Title(string bookTitle)
        {
            title = bookTitle;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Title: " + title);
            Console.ResetColor();
        }
    }
}


