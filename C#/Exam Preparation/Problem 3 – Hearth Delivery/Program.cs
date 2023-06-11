using System;
using System.Collections.Generic;
using System.Linq;

class MemoryGame
{
    static void Main()
    {
        List<string> sequence = Console.ReadLine().Split().ToList();
        int moves = 0;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
                break;

            int[] indexes = input.Split().Select(int.Parse).ToArray();
            int index1 = indexes[0];
            int index2 = indexes[1];

            if (IsInvalidInput(index1, index2, sequence.Count))
            {
                int additionalElementIndex = sequence.Count / 2;
                string additionalElement = $"-{moves + 1}a";
                sequence.Insert(additionalElementIndex, additionalElement);
                sequence.Insert(additionalElementIndex, additionalElement);
                Console.WriteLine("Invalid input! Adding additional elements to the board");
            }
            else if (IsMatchingPair(index1, index2, sequence))
            {
                string element = sequence[index1];
                sequence.RemoveAll(e => e == element);
                Console.WriteLine($"Congrats! You have found matching elements - {element}!");
            }
            else
            {
                Console.WriteLine("Try again!");
            }

            moves++;

            if (sequence.Count == 0)
            {
                Console.WriteLine($"You have won in {moves} turns!");
                return;
            }
        }

        Console.WriteLine($"Sorry you lose :(\n{string.Join(" ", sequence)}");
    }

    static bool IsInvalidInput(int index1, int index2, int sequenceLength)
    {
        return index1 == index2 || index1 < 0 || index1 >= sequenceLength || index2 < 0 || index2 >= sequenceLength;
    }

    static bool IsMatchingPair(int index1, int index2, List<string> sequence)
    {
        return sequence[index1] == sequence[index2];
    }
}
