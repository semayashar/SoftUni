using System;
using System.Collections.Generic;
using System.Linq;

public class AnonymousThreat
{
    public static void Main(string[] args)
    {
        List<string> data = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string command = Console.ReadLine();

        while (command != "3:1")
        {
            string[] commandParts = command.Split(' ');
            string action = commandParts[0];

            if (action == "merge")
            {
                int startIndex = int.Parse(commandParts[1]);
                int endIndex = int.Parse(commandParts[2]);

                MergeData(data, startIndex, endIndex);
            }
            else if (action == "divide")
            {
                int index = int.Parse(commandParts[1]);
                int partitions = int.Parse(commandParts[2]);

                DivideData(data, index, partitions);
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(' ', data));
    }

    private static void MergeData(List<string> data, int startIndex, int endIndex)
    {
        if (startIndex < 0)
        {
            startIndex = 0;
        }

        if (endIndex >= data.Count)
        {
            endIndex = data.Count - 1;
        }

        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            data[startIndex] += data[i];
        }

        data.RemoveRange(startIndex + 1, endIndex - startIndex);
    }

    private static void DivideData(List<string> data, int index, int partitions)
    {
        string element = data[index];
        int partitionSize = (int)Math.Ceiling((double)element.Length / partitions);

        List<string> dividedElements = new List<string>();

        for (int i = 0; i < element.Length; i += partitionSize)
        {
            if (i + partitionSize > element.Length)
            {
                dividedElements.Add(element.Substring(i));
            }
            else
            {
                dividedElements.Add(element.Substring(i, partitionSize));
            }
        }

        data.RemoveAt(index);
        data.InsertRange(index, dividedElements);
    }
}
