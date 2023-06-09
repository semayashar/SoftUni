using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> firstList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> secondList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> mergedList = new List<int>();

        int minLength = Math.Min(firstList.Count, secondList.Count);

        for (int i = 0; i < minLength; i++)
        {
            mergedList.Add(firstList[i]);
            mergedList.Add(secondList[i]);
        }

        if (firstList.Count > secondList.Count)
        {
            mergedList.AddRange(firstList.Skip(minLength));
        }
        else if (secondList.Count > firstList.Count)
        {
            mergedList.AddRange(secondList.Skip(minLength));
        }

        Console.WriteLine(string.Join(" ", mergedList));
    }
}
