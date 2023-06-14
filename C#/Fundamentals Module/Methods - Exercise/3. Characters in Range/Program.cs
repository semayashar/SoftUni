namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void PrintCharactersInRange(char start, char end)
        {
            if (start > end)
            {
                char temp = start;
                start = end;
                end = temp;
            }

            for (char c = (char)(start + 1); c < end; c++)
            {
                Console.Write(c + " ");
            }
        }

        static void Main(string[] args)
        {
            PrintCharactersInRange(Char.Parse(Console.ReadLine()), Char.Parse(Console.ReadLine()));
        }
    }
}