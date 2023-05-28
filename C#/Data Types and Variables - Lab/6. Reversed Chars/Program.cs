namespace _6._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read three lines of characters
            Console.WriteLine("Enter the first line:");
            string line1 = Console.ReadLine();

            Console.WriteLine("Enter the second line:");
            string line2 = Console.ReadLine();

            Console.WriteLine("Enter the third line:");
            string line3 = Console.ReadLine();

            // Print the lines in reversed order
            Console.WriteLine("Reversed order with space between them:");
            Console.WriteLine(line3 + " " + line2 + " " + line1);
        }
    }
}