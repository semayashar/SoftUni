using System;

class Program
{
    static void Main()
    {
        double neededExperience = double.Parse(Console.ReadLine());
        int battleCount = int.Parse(Console.ReadLine());

        double totalExperience = 0;
        int specialBattlesCount = 0;

        for (int i = 1; i <= battleCount; i++)
        {
            double battleExperience = double.Parse(Console.ReadLine());

            if (i % 3 == 0)
            {
                battleExperience += battleExperience * 0.15;
                specialBattlesCount++;
            }

            if (i % 5 == 0)
            {
                battleExperience -= battleExperience * 0.1;
                specialBattlesCount++;
            }

            if (i % 15 == 0)
            {
                battleExperience += battleExperience * 0.05;
                specialBattlesCount++;
            }

            totalExperience += battleExperience;

            if (totalExperience >= neededExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                return;
            }
        }

        double remainingExperience = neededExperience - totalExperience;
        Console.WriteLine($"Player was not able to collect the needed experience, {remainingExperience:f2} more needed.");
    }
}
