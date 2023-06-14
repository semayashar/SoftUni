namespace _2._Vowels_Count
{
    internal class Program
    {
        static int CountVowels(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return Array.IndexOf(vowels, c) >= 0;
        }

        static void Main(string[] args)
        {
            int vowelCount = CountVowels(Console.ReadLine());
            Console.WriteLine(vowelCount);
        }
    }
}