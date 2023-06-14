using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] tokens = command.Split(' ');
            string action = tokens[0];
            int index1 = int.Parse(tokens[1]);
            int index2 = int.Parse(tokens[2]);

            switch (action)
            {
                case "swap":
                    Swap(array, index1, index2);
                    break;
                case "multiply":
                    Multiply(array, index1, index2);
                    break;
                case "decrease":
                    Decrease(array);
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", array));
    }

    static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    static void Multiply(int[] array, int index1, int index2)
    {
        array[index1] *= array[index2];
    }

    static void Decrease(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i]--;
        }
    }
}
