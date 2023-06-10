using System;
using System.Collections.Generic;
using System.Linq;

public class ChangeList
{
    public static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split(' ');

            if (command[0] == "Delete")
            {
                int element = int.Parse(command[1]);
                numbers.RemoveAll(num => num == element);
            }
            else if (command[0] == "Insert")
            {
                int element = int.Parse(command[1]);
                int position = int.Parse(command[2]);
                numbers.Insert(position, element);
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
