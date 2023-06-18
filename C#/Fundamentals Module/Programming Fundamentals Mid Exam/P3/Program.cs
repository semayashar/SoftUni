using System;
using System.Collections.Generic;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

class Program
{
    static void Main()
    {
        List<string> cardDeck = Console.ReadLine().Split(", ").ToList();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split(", ");
            string action = command[0];

            if (action != "Insert")
            {
                string cardName = command[1];

                if (action == "Add")
                {
                    //"Add, [CardName}":
                    if (cardDeck.Contains(cardName))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        cardDeck.Add(cardName);
                        Console.WriteLine("Card successfully added");
                    }
                }

                if (action == "Remove")
                {
                    //"Remove, {CardName}": 
                    if (cardDeck.Contains(cardName))
                    {
                        cardDeck.Remove(cardName);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                if (action == "Remove At")
                {
                    //"Remove At, {index}": 
                    int index = int.Parse(cardName);
                    if (index >= 0 && index < cardDeck.Count)
                    {
                        cardDeck.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            else
            {
                if (action == "Insert")
                {
                    //"Insert, {index}, {CardName}": 
                    int insertIndex = int.Parse(command[1]);
                    string cardName = command[2];

                    if (insertIndex >= 0 && insertIndex < cardDeck.Count)
                    {
                        if (cardDeck.Contains(cardName))
                        {
                            Console.WriteLine("Card is already added");
                        }
                        else
                        {
                            cardDeck.Insert(insertIndex, cardName);
                            Console.WriteLine("Card successfully added");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
        }
        Console.WriteLine(string.Join(", ", cardDeck));
    }
}