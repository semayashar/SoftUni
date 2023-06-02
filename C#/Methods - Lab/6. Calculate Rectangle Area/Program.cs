namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static int CalculateRectangleArea(int width, int height)
        {
            int area = width * height;
            return area;
        }

        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = CalculateRectangleArea(width, height);
            Console.WriteLine(area);
        }
    }
}