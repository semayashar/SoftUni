namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumOfEvens = GetSumOfEvenDigits(number);
            int sumOfOdds = GetSumOfOddDigits(number);
            int result = sumOfEvens * sumOfOdds;
            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number); // Ensure positive number

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number); // Ensure positive number

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }
    }
}