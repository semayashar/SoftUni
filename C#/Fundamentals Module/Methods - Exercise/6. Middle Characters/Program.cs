namespace _6._Middle_Characters
{
    internal class Program
    {
        static void PrintMiddleCharacter(string input)
        {
            int middleIndex = input.Length / 2;

            if (input.Length % 2 == 0)
            {
                Console.WriteLine(input[middleIndex - 1].ToString() + input[middleIndex].ToString());
            }
            else
            {
                Console.WriteLine(input[middleIndex]);
            }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }
    }
}