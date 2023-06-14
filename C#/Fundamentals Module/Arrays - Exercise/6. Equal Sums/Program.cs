namespace _6._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            bool foundIndex = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                // Calculate the sum of elements to the left of the current index
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                // Calculate the sum of elements to the right of the current index
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                // Check if the sums are equal
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    foundIndex = true;
                    break;
                }
            }

            if (!foundIndex)
            {
                Console.WriteLine("no");
            }
        }
    }
}