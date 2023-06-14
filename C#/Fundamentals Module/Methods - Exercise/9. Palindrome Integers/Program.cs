namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static bool IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isPalindrome = IsPalindrome(input);
                Console.WriteLine(isPalindrome.ToString().ToLower());

                input = Console.ReadLine();
            }
        }
    }
}