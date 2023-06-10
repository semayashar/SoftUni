using System;
using System.Collections.Generic;
using System.Linq;

public class AppendArrays
{
    public static void Main(string[] args)
    {
        string[] arrays = Console.ReadLine()
            .Split('|')
            .Reverse()
            .ToArray();

        List<int> result = new List<int>();

        foreach (string array in arrays)
        {
            int[] numbers = array
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            result.AddRange(numbers);
        }

        Console.WriteLine(string.Join(' ', result));
    }
}
