namespace _8._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the name of the town
            Console.WriteLine("Enter the name of the town:");
            string townName = Console.ReadLine();

            // Read the population
            Console.WriteLine("Enter the population:");
            int population = int.Parse(Console.ReadLine());

            // Read the area
            Console.WriteLine("Enter the area in square km:");
            int area = int.Parse(Console.ReadLine());

            // Print the result
            Console.WriteLine("Town " + townName + " has population of " + population + " and area " + area + " square km.");
        }
    }
}