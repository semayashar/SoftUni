namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfLetters = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLetters; i++)
            {
                for (int j = 0; j < numOfLetters; j++)
                {
                    for (int k = 0; k < numOfLetters; k++)
                    {
                        char firstLetter = (char)('a' + i);
                        char secondLetter = (char)('a' + j);
                        char thirdLetter = (char)('a' + k);

                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}