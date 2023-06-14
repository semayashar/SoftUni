namespace _Reading_Array_from_a_Single_Line_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lineOfNumbers = Console.ReadLine();
            string[] numbersString = lineOfNumbers.Split();
            int[] numbersInt = new int[numbersString.Length];
            for (int i = 0; i < numbersString.Length; i++)
            {
                numbersInt[i] = int.Parse(numbersString[i]);
            }

            for (int i = 0; i < numbersInt.Length; i++)
            {
                Console.WriteLine(numbersInt[i]);
            }

            /* shorter:
            int[] numbersInt = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            */
        }
    }
}