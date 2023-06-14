using System;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Array.Reverse(input);
            string result = 
                string.Join(" ", 
                input.Select(x => x.ToString()));
            Console.WriteLine(result);
        }
    }
}