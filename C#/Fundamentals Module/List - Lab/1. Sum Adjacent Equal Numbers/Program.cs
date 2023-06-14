using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<decimal> numbers = Console.ReadLine()
            .Split()
            .Select(decimal.Parse)
            .ToList();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                decimal sum = numbers[i] + numbers[i + 1];
                numbers[i] = sum;
                numbers.RemoveAt(i + 1);
                i = -1; // Reset the loop
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
