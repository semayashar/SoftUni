using System;

class Program
{
    static void Main(string[] args)
    {
        string[] routes = Console.ReadLine().Split("||");
        int fuel = int.Parse(Console.ReadLine());
        int ammunition = int.Parse(Console.ReadLine());

        foreach (string route in routes)
        {
            string[] command = route.Split(' ');
            string action = command[0];
            if (action != "Titan")
            {
                int value = int.Parse(command[1]);

                if (action == "Travel")
                {
                    if (fuel >= value)
                    {
                        fuel -= value;
                        Console.WriteLine($"The spaceship travelled {value} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (action == "Enemy")
                {
                    int enemyArmor = value;

                    if (ammunition >= enemyArmor)
                    {
                        ammunition -= enemyArmor;
                        Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
                    }
                    else
                    {
                        int fuelConsumed = enemyArmor * 2;
                        fuel -= fuelConsumed;
                        if (fuel >= 0)
                        {
                            Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                    }
                }
                else if (action == "Repair")
                {
                    int ammoToAdd = value * 2;
                    int fuelToAdd = value;

                    ammunition += ammoToAdd;
                    fuel += fuelToAdd;

                    Console.WriteLine($"Ammunitions added: {ammoToAdd}.");
                    Console.WriteLine($"Fuel added: {fuelToAdd}.");
                }
            }
            else
            {
                Console.WriteLine("You have reached Titan, all passengers are safe.");
                return;
            }
        }
    }
}
