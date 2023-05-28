using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A program that reads a sequence of numbers. 
                If the number is even, print its absolute value in the following format: 
                    "The number is: {number}" and terminate the program. 
                If the number is odd, print "Please write an even number." and continue reading numbers. */

            int number = int.Parse(Console.ReadLine());
            while(number % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                number = int.Parse(Console.ReadLine());
            }

            number = Math.Abs(number);
            Console.WriteLine($"The number is: {number}");
        }
    }
}