namespace _2._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read n numbers and save them in reverse order, separated by a single space.

            int countOfNumber = int.Parse(Console.ReadLine());
            int[] numberArray = new int [countOfNumber];
            --countOfNumber;

            while (countOfNumber >= 0)
            {
                numberArray[countOfNumber--] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }

            //Resetting the parameters:
            Array.Clear(numberArray, 0, numberArray.Length);
            Console.WriteLine("Reset");


            //Read n numbers and print them in reverse order, separated by a single space.

            countOfNumber = int.Parse(Console.ReadLine());
            Array.Resize(ref numberArray, countOfNumber);

            for (int i = 0; i < countOfNumber; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }


        }
    }
}