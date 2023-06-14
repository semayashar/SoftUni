using System;

namespace SumofOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A program that prints on a new line the next n odd numbers (starting from 1). 
               On the last row print the sum of all n odd numbers. */

            /*Input
                A single number n is read from the console, indicating how many odd numbers need to be printed */
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            //Logic:
            for (int i = 1; n != 0; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    n--;
                }
            }

            //Print:
            Console.WriteLine($"Sum: {sum}");
        }
    }
}