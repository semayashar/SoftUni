namespace _1._Sign_of_Integer_Numbers
{
    internal class Program
    {
        public static void checkNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        static void Main(string[] args)
        {
            checkNumber(int.Parse(Console.ReadLine()));
        }
    }
}