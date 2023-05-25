namespace _9._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the characters
            Console.WriteLine("Enter the first character:");
            char char1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second character:");
            char char2 = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third character:");
            char char3 = char.Parse(Console.ReadLine());

            // Combine the characters into a string
            string combinedString = char1.ToString() + char2.ToString() + char3.ToString();

            // Print the combined string
            Console.WriteLine("Combined string: " + combinedString);
        }
    }
}