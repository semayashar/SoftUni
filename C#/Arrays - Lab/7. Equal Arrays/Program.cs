namespace _7._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            int[] arr2 = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            bool areIdentical = arr1.SequenceEqual(arr2);

            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: " + arr1.Sum());
            }
            else
            {
                int index = -1;

                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        index = i;
                        break;
                    }
                }

                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}