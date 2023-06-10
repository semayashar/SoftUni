using System;
using System.Collections.Generic;
using System.Linq;

public class BombNumbers
{
    public static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        int[] bombInfo = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int bombNumber = bombInfo[0];
        int bombPower = bombInfo[1];

        while (numbers.Contains(bombNumber))
        {
            int bombIndex = numbers.IndexOf(bombNumber);
            int leftBound = Math.Max(0, bombIndex - bombPower);
            int rightBound = Math.Min(numbers.Count - 1, bombIndex + bombPower);

            numbers.RemoveRange(leftBound, rightBound - leftBound + 1);
        }

        int sum = numbers.Sum();
        Console.WriteLine(sum);
    }
}
