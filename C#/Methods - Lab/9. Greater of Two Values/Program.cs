namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        static char GetMax(char a, char b)
        {
            return (a > b) ? a : b;
        }

        static string GetMax(string a, string b)
        {
            return (string.Compare(a, b) > 0) ? a : b;
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string result = GetMax(a, b);
                Console.WriteLine(result);
            }
        }
    }
}