namespace ME___5._Longest_Increasing_Subsequence__LIS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] len = new int[nums.Count];
            int[] prev = new int[nums.Count];
            int maxLength = 0;
            int maxIndex = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i] && len[j] >= len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    maxIndex = i;
                }
            }

            List<int> lis = new List<int>();
            while (maxIndex != -1)
            {
                lis.Add(nums[maxIndex]);
                maxIndex = prev[maxIndex];
            }
            lis.Reverse();

            Console.WriteLine(string.Join(" ", lis));
        }
    }
}