using System;

namespace _4._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A program that receives an array and several rotations that you have to perform. 
             * The rotations are done by moving the first element of the array from the front to the back. 
             * Print the resulting array*/

            List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int fe = numbers.First();
                numbers.Remove(numbers.First());
                numbers.Add(fe);
            }

            Console.Write(string.Join(" ", numbers));
         }
    }
}