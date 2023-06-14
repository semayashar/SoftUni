using System;
using System.Collections;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read an array of real numbers (space separated), round them in "away from 0" style and print
            
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] numbersRounded = Array.ConvertAll(numbers, x => (int)Math.Round(x, MidpointRounding.AwayFromZero));

            for (int i = 0; i < numbersRounded.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, numbersRounded[i]);
            }
        }
    }
}