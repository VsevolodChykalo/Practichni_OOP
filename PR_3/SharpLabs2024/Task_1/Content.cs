namespace CSharpLabs2024.Task1
{
    internal class Content
    {
        private string? text;

        // Властивість для доступу до змісту книги
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        // Метод для виведення змісту книги
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Content: " + text);
            Console.ResetColor();
        }
    }
}