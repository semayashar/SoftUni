namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives a single integer
            //and finds the sum of its digits.

            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while(number > 0)
            {
                int lastDig = number % 10;
                sum += lastDig;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}