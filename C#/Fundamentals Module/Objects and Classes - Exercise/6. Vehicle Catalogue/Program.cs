using System;
using System.Collections.Generic;
using System.Linq;

class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        double totalCarHorsepower = 0;
        double totalTruckHorsepower = 0;
        int carCount = 0;
        int truckCount = 0;

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] vehicleInfo = input.Split(' ');

            string type = vehicleInfo[0];
            string model = vehicleInfo[1];
            string color = vehicleInfo[2];
            int horsepower = int.Parse(vehicleInfo[3]);

            Vehicle vehicle = new Vehicle()
            {
                Type = type,
                Model = model,
                Color = color,
                Horsepower = horsepower
            };

            vehicles.Add(vehicle);

            if (type == "car")
            {
                totalCarHorsepower += horsepower;
                carCount++;
            }
            else if (type == "truck")
            {
                totalTruckHorsepower += horsepower;
                truckCount++;
            }
        }

        while ((input = Console.ReadLine()) != "Close the Catalogue")
        {
            string model = input;

            Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == model);

            if (vehicle != null)
            {
                Console.WriteLine($"Type: {vehicle.Type}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
            }
        }

        double averageCarHorsepower = 0;
        double averageTruckHorsepower = 0;

        if (carCount > 0)
        {
            averageCarHorsepower = totalCarHorsepower / carCount;
        }

        if (truckCount > 0)
        {
            averageTruckHorsepower = totalTruckHorsepower / truckCount;
        }

        Console.WriteLine($"Cars have average horsepower of: {averageCarHorsepower:f2}.");
        Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsepower:f2}.");
    }
}
