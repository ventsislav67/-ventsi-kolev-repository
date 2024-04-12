namespace Human
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person human = new Person();
            Console.Write("въведете име:");
            human.Name = Console.ReadLine();
            Console.Write("Въведете години:");
            human.age = int.Parse(Console.ReadLine());
            Console.Write("Въведете пол:");
            human.pol = Console.ReadLine();
            human.writeforhuman();
        }
    }
}