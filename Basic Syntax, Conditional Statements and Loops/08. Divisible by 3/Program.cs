using System;

namespace DivisibleBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A program, which prints all the numbers from 1 to 100, that are divisible by 3. 
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}