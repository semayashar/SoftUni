namespace _7._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the first name
            Console.WriteLine("Enter the first name:");
            string firstName = Console.ReadLine();

            // Read the second name
            Console.WriteLine("Enter the second name:");
            string secondName = Console.ReadLine();

            // Read the delimiter
            Console.WriteLine("Enter the delimiter:");
            string delimiter = Console.ReadLine();

            // Join the names with the delimiter
            string result = firstName + delimiter + secondName;

            // Print the result
            Console.WriteLine("Output:");
            Console.WriteLine(result);
        }
    }
}