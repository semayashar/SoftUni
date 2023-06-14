namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            var commonElements = arr1.Intersect(arr2);

            Console.WriteLine(string.Join(" ", commonElements));
        }
    }
}