using System;
using System.Collections.Generic;
using System.Linq;

public class ListOperations
{
    public static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] command = input.Split(' ');

            switch (command[0])
            {
                case "Add":
                    int numberToAdd = int.Parse(command[1]);
                    numbers.Add(numberToAdd);
                    break;

                case "Insert":
                    int numberToInsert = int.Parse(command[1]);
                    int indexToInsert = int.Parse(command[2]);

                    if (IsValidIndex(indexToInsert, numbers))
                    {
                        numbers.Insert(indexToInsert, numberToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case "Remove":
                    int indexToRemove = int.Parse(command[1]);

                    if (IsValidIndex(indexToRemove, numbers))
                    {
                        numbers.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case "Shift":
                    string direction = command[1];
                    int count = int.Parse(command[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstNumber = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstNumber);
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastNumber);
                        }
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }

    public static bool IsValidIndex(int index, List<int> numbers)
    {
        return index >= 0 && index < numbers.Count;
    }
}
