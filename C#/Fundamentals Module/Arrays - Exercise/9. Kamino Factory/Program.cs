namespace _9._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int bestSequenceIndex = int.MaxValue;
            int bestSequenceLength = 0;
            int bestSequenceSum = 0;
            int[] bestSequenceDNA = new int[dnaLength];

            int sequenceIndex = 0;

            while (command != "Clone them!")
            {
                int[] currentSequence = command
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentSequenceLength = 0;
                int currentSequenceSum = 0;

                int currentIndex = 0;
                int longestSubsequenceStartIndex = 0;
                int longestSubsequenceLength = 0;

                for (int i = 0; i < currentSequence.Length; i++)
                {
                    if (currentSequence[i] == 1)
                    {
                        currentSequenceLength++;
                        currentSequenceSum++;

                        if (currentSequenceLength > longestSubsequenceLength)
                        {
                            longestSubsequenceLength = currentSequenceLength;
                            longestSubsequenceStartIndex = currentIndex;
                        }
                    }
                    else
                    {
                        currentSequenceLength = 0;
                    }

                    currentIndex++;
                }

                if ((longestSubsequenceLength > bestSequenceLength) ||
                    (longestSubsequenceLength == bestSequenceLength && longestSubsequenceStartIndex < bestSequenceIndex) ||
                    (longestSubsequenceLength == bestSequenceLength && longestSubsequenceStartIndex == bestSequenceIndex && currentSequenceSum > bestSequenceSum))
                {
                    bestSequenceIndex = longestSubsequenceStartIndex;
                    bestSequenceLength = longestSubsequenceLength;
                    bestSequenceSum = currentSequenceSum;
                    bestSequenceDNA = currentSequence;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequenceDNA));
        }
    }
}