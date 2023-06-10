using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
        int removedSum = 0;

        while (sequence.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());
            int removedValue;

            if (index < 0)
            {
                removedValue = sequence[0];
                sequence[0] = sequence[sequence.Count - 1];
            }
            else if (index >= sequence.Count)
            {
                removedValue = sequence[sequence.Count - 1];
                sequence[sequence.Count - 1] = sequence[0];
            }
            else
            {
                removedValue = sequence[index];
                sequence.RemoveAt(index);
            }

            removedSum += removedValue;

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] <= removedValue)
                {
                    sequence[i] += removedValue;
                }
                else
                {
                    sequence[i] -= removedValue;
                }
            }
        }

        Console.WriteLine(removedSum);
    }
}
