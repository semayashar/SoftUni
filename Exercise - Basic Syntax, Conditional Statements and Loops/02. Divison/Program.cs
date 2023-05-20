namespace _02._Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*You will be given an integer, write a program which checks 
             * if the given integer is divisible by 2 or 3, or 6, or 7, or 10 without a remainder.
             * You should always take the bigger division:*/

            int number = int.Parse(Console.ReadLine());

            if (number % 10 == 0)
            {
                Console.WriteLine($"The number is divisible by 10");
            }
            else if(number % 7 == 0)
            {
                Console.WriteLine($"The number is divisible by 7");
            }
            else if (number % 6 == 0)
            {
                Console.WriteLine($"The number is divisible by 6");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine($"The number is divisible by 3");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine($"The number is divisible by 2");
            }
            else
            {
                Console.WriteLine($"Not divisible");
            }
        }
    }
}