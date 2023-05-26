namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKegModel = string.Empty;
            double biggestKegVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (kegVolume > biggestKegVolume)
                {
                    biggestKegVolume = kegVolume;
                    biggestKegModel = model;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}