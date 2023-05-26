namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*a program, which sums the ASCII codes 
             * of n characters and prints the sum on the console*/

            int numberOfLines = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter; 
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}