namespace _5._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read an array from the console and sum only its even values. 

            int[] numbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                Where(x => x % 2 == 0).
                ToArray();
            Console.WriteLine(numbers.Sum());
        }
    }
}