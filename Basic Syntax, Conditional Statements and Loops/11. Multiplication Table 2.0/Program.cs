using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A program that receives a number and a multiplier from the console. 
               Prints the table with the multiplier in the interval from the given number to 10.
               If the given multiplier is more than 10, print only one row with the integer, the given multiplier, and the product. */

            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
        }
    }
}