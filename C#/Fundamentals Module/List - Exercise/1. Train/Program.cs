﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Train
{
    public static void Main(string[] args)
    {
        List<int> wagons = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        int maxCapacity = int.Parse(Console.ReadLine());

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split(' ');

            if (command[0] == "Add")
            {
                int passengers = int.Parse(command[1]);
                wagons.Add(passengers);
            }
            else
            {
                int passengers = int.Parse(command[0]);

                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i] + passengers <= maxCapacity)
                    {
                        wagons[i] += passengers;
                        break;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", wagons));
    }
}
