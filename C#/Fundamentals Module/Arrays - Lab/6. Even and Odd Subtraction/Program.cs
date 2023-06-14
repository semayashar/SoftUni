namespace _6._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A program that calculates the difference between 
              the sum of the even and the sum of the odd numbers in
              an array.*/

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] oddNum = numbers.Where(x => x % 2 != 0).ToArray();
            int[] evenNum = numbers.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(oddNum.Sum() - evenNum.Sum());
        }
    }
}