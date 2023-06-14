using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> inventory = Console.ReadLine()
            .Split(", ")
            .ToList();

        string command = Console.ReadLine();

        while (command != "Craft!")
        {
            string[] tokens = command.Split(" - ");
            string action = tokens[0];
            string item = tokens[1];

            switch (action)
            {
                case "Collect":
                    CollectItem(inventory, item);
                    break;
                case "Drop":
                    DropItem(inventory, item);
                    break;
                case "Combine Items":
                    CombineItems(inventory, item);
                    break;
                case "Renew":
                    RenewItem(inventory, item);
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", inventory));
    }

    static void CollectItem(List<string> inventory, string item)
    {
        if (!inventory.Contains(item))
        {
            inventory.Add(item);
        }
    }

    static void DropItem(List<string> inventory, string item)
    {
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
        }
    }

    static void CombineItems(List<string> inventory, string items)
    {
        string[] tokens = items.Split(":");
        string oldItem = tokens[0];
        string newItem = tokens[1];

        int index = inventory.IndexOf(oldItem);
        if (index != -1)
        {
            inventory.Insert(index + 1, newItem);
        }
    }

    static void RenewItem(List<string> inventory, string item)
    {
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
            inventory.Add(item);
        }
    }
}
