using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] commandParts = input.Split();
            string command = commandParts[0];

            if (command == "exchange")
            {
                int index = int.Parse(commandParts[1]);
                if (index < 0 || index >= numbers.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    numbers = Exchange(numbers, index);
                }
            }
            else if (command == "max")
            {
                string evenOrOdd = commandParts[1];
                int maxIndex = GetMaxIndex(numbers, evenOrOdd);
                if (maxIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(maxIndex);
                }
            }
            else if (command == "min")
            {
                string evenOrOdd = commandParts[1];
                int minIndex = GetMinIndex(numbers, evenOrOdd);
                if (minIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(minIndex);
                }
            }
            else if (command == "first")
            {
                int count = int.Parse(commandParts[1]);
                string evenOrOdd = commandParts[2];
                if (count < 0 || count > numbers.Count)
                {
                    Console.WriteLine("Invalid count");
                }
                else
                {
                    List<int> result = GetFirstElements(numbers, count, evenOrOdd);
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }
            }
            else if (command == "last")
            {
                int count = int.Parse(commandParts[1]);
                string evenOrOdd = commandParts[2];
                if (count < 0 || count > numbers.Count)
                {
                    Console.WriteLine("Invalid count");
                }
                else
                {
                    List<int> result = GetLastElements(numbers, count, evenOrOdd);
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    static List<int> Exchange(List<int> numbers, int index)
    {
        List<int> firstSublist = numbers.Take(index + 1).ToList();
        List<int> secondSublist = numbers.Skip(index + 1).ToList();
        return secondSublist.Concat(firstSublist).ToList();
    }

    static int GetMaxIndex(List<int> numbers, string evenOrOdd)
    {
        List<int> filteredNumbers = evenOrOdd == "even" ? numbers.Where(n => n % 2 == 0).ToList() : numbers.Where(n => n % 2 != 0).ToList();
        if (filteredNumbers.Count == 0)
        {
            return -1;
        }
        int maxNumber = filteredNumbers.Max();
        return numbers.LastIndexOf(maxNumber);
    }

    static int GetMinIndex(List<int> numbers, string evenOrOdd)
    {
        List<int> filteredNumbers = evenOrOdd == "even" ? numbers.Where(n => n % 2 == 0).ToList() : numbers.Where(n => n % 2 != 0).ToList();
        if (filteredNumbers.Count == 0)
        {
            return -1;
        }
        int minNumber = filteredNumbers.Min();
        return numbers.LastIndexOf(minNumber);
    }

    static List<int> GetFirstElements(List<int> numbers, int count, string evenOrOdd)
    {
        List<int> filteredNumbers = evenOrOdd == "even" ? numbers.Where(n => n % 2 == 0).ToList() : numbers.Where(n => n % 2 != 0).ToList();
        return filteredNumbers.Take(count).ToList();
    }

    static List<int> GetLastElements(List<int> numbers, int count, string evenOrOdd)
    {
        List<int> filteredNumbers = evenOrOdd == "even" ? numbers.Where(n => n % 2 == 0).ToList() : numbers.Where(n => n % 2 != 0).ToList();
        return filteredNumbers.Skip(filteredNumbers.Count - count).ToList();
    }
}
