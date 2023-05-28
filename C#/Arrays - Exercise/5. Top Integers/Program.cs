﻿namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A program to find all the top integers in an array. A top integer is an integer 
             * that is greater than all the elements to its right*/

            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopInteger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}