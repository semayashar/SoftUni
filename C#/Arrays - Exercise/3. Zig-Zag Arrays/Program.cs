namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that creates 2 arrays. You will be given an integer n. 
             * On the next n lines, you will get 2 integers. Form 2 new arrays in a zig-zag pattern*/

            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    array1[i] = numbers[0];
                    array2[i] = numbers[1];
                }
                else
                {
                    array1[i] = numbers[1];
                    array2[i] = numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}