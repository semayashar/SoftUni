namespace _5._Special_Numbers
{
    internal class Program
    {
        static bool IsSpecialNumber(int number)
        {
            int sumOfDigits = 0;

            // Calculate the sum of the digits
            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            // Check if the sum of digits is 5, 7, or 11
            return sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
        }

        static void Main(string[] args)
        {
            //A number is special when its sum of digits is 5, 7 or 11.

            // Read the value of n from the user
        Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            // Check each number in the range 1 to n
            for (int i = 1; i <= n; i++)
            {
                bool isSpecial = IsSpecialNumber(i);
                Console.WriteLine(i + ": " + isSpecial);
            }
        }
    }
}