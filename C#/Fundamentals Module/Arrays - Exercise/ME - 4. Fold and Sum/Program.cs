namespace ME___4._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] upperRowLeft = numbers.Take(k).Reverse().ToArray();
            int[] upperRowRight = numbers.Reverse().Take(k).ToArray();
            int[] upperRow = upperRowLeft.Concat(upperRowRight).ToArray();
            int[] lowerRow = numbers.Skip(k).Take(2 * k).ToArray();

            int[] summedRows = new int[2 * k];
            for (int i = 0; i < 2 * k; i++)
            {
                summedRows[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", summedRows));
        }
    }
}