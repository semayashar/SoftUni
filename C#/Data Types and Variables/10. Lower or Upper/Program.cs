namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the character from the user
            Console.WriteLine("Enter a character:");
            char character = char.Parse(Console.ReadLine());

            // Check if the character is upper-case or lower-case
            if (char.IsUpper(character))
            {
                Console.WriteLine("upper-case");
            }
            else if (char.IsLower(character))
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("The character is not a letter.");
            }
        }
    }
}