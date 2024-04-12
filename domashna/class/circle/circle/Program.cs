namespace circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle circle = new circle();
            Console.Write("Въведете радиус:");
            circle.Radius = int.Parse(Console.ReadLine());
            Console.WriteLine(circle.calculateperimeter());
        }
    }
}