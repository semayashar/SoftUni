namespace _7._Repeat_String
{
    internal class Program
    {
        static string RepeatStringWithoutSpaces(string text, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result = result + text;
            }
            return result;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatStringWithoutSpaces(text, n);
            Console.WriteLine(result);
        }
    }
}