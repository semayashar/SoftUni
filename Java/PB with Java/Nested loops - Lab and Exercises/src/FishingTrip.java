import java.util.Scanner;

public class FishingTrip {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int budget;
        String season;
        int fishermenCount;
        double price = 0;

        // Read input from the user
        System.out.print("Budget: ");
        budget = scanner.nextInt();
        System.out.print("Season: ");
        season = scanner.next();
        System.out.print("Fishermen count: ");
        fishermenCount = scanner.nextInt();

        // Calculate the price based on the season and fishermen count
        if (season.equals("Spring")) {
            price = 3000;
        } else if (season.equals("Summer") || season.equals("Autumn")) {
            price = 4200;
        } else if (season.equals("Winter")) {
            price = 2600;
        }

        // Apply discount based on the fishermen count
        if (fishermenCount <= 6) {
            price -= 0.1 * price;
        } else if (fishermenCount <= 11) {
            price -= 0.15 * price;
        } else if (fishermenCount >= 12) {
            price -= 0.25 * price;
        }

        // Check if additional discount applies for even number of fishermen (except for Autumn)
        if (!season.equals("Autumn") && fishermenCount % 2 == 0) {
            price -= 0.05 * price;
        }

        double remainingBudget = budget - price;

        // Print the result
        if (remainingBudget >= 0) {
            System.out.printf("Yes! You have %.2f leva left.\n", remainingBudget);
        } else {
            System.out.printf("Not enough money! You need %.2f leva.\n", -remainingBudget);
        }

        scanner.close();
    }
}
