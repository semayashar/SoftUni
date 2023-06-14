using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> result = new List<int>();

        while (numbers.Count > 0)
        {
            if (numbers.Count == 1)
            {
                result.Add(numbers[0]);
                break;
            }

            int firstNumber = numbers[0];
            int lastNumber = numbers[numbers.Count - 1];

            int sum = firstNumber + lastNumber;
            result.Add(sum);

            numbers.RemoveAt(0);
            numbers.RemoveAt(numbers.Count - 1);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
