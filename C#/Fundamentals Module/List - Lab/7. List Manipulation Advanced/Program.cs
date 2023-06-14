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

        string command = Console.ReadLine();
        bool listChanged = false;

        while (command != "end")
        {
            string[] tokens = command.Split();

            switch (tokens[0])
            {
                case "Contains":
                    int numberToCheck = int.Parse(tokens[1]);
                    if (numbers.Contains(numberToCheck))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;
                case "PrintEven":
                    List<int> evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
                    Console.WriteLine(string.Join(" ", evenNumbers));
                    break;
                case "PrintOdd":
                    List<int> oddNumbers = numbers.Where(num => num % 2 != 0).ToList();
                    Console.WriteLine(string.Join(" ", oddNumbers));
                    break;
                case "GetSum":
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                    break;
                case "Filter":
                    string condition = tokens[1];
                    int filterNumber = int.Parse(tokens[2]);

                    List<int> filteredNumbers = new List<int>();

                    switch (condition)
                    {
                        case "<":
                            filteredNumbers = numbers.Where(num => num < filterNumber).ToList();
                            break;
                        case ">":
                            filteredNumbers = numbers.Where(num => num > filterNumber).ToList();
                            break;
                        case ">=":
                            filteredNumbers = numbers.Where(num => num >= filterNumber).ToList();
                            break;
                        case "<=":
                            filteredNumbers = numbers.Where(num => num <= filterNumber).ToList();
                            break;
                    }

                    Console.WriteLine(string.Join(" ", filteredNumbers));
                    break;
            }

            command = Console.ReadLine();
            listChanged = true;
        }

        if (listChanged)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
