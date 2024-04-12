namespace book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book book = new book();
            Console.Write("Въведете Книга:");
            book.title = Console.ReadLine();
            Console.Write("Въведете автор:");
            book.author = Console.ReadLine();
            Console.Write("Въведете година на издаване:");
            book.age = int.Parse(Console.ReadLine());
            book.writeall();
        }
    }
}