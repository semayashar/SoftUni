using System;

namespace Problem_2___MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string[] liftState = Console.ReadLine().Split();

            int[] wagons = new int[liftState.Length];
            for (int i = 0; i < liftState.Length; i++)
            {
                wagons[i] = int.Parse(liftState[i]);
            }

            for (int i = 0; i < wagons.Length; i++)
            {
                while (wagons[i] < 4 && people > 0)
                {
                    wagons[i]++;
                    people--;
                }
            }

            if (people == 0 && Array.IndexOf(wagons, 0) != -1)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (people > 0 && Array.IndexOf(wagons, 0) == -1)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }


}