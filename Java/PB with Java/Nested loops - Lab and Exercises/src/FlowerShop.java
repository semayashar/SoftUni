import java.util.Scanner;

public class FlowerShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String flowerType;
        int flowerCount;
        int budget;
        double price = 0;
        double discount = 0;

        // Read input from the user
        System.out.print("Flower type: ");
        flowerType = scanner.nextLine();
        System.out.print("Flower count: ");
        flowerCount = scanner.nextInt();
        System.out.print("Budget: ");
        budget = scanner.nextInt();

        // Calculate the price based on the flower type and count
        if (flowerType.equals("Roses")) {
            price = 5.0 * flowerCount;
            if (flowerCount > 80)
                discount = 0.1 * price;
        } else if (flowerType.equals("Dahlias")) {
            price = 3.8 * flowerCount;
            if (flowerCount > 90)
                discount = 0.15 * price;
        } else if (flowerType.equals("Tulips")) {
            price = 2.8 * flowerCount;
            if (flowerCount > 80)
                discount = 0.15 * price;
        } else if (flowerType.equals("Narcissus")) {
            price = 3.0 * flowerCount;
            if (flowerCount < 120)
                price += 0.15 * price;
        } else if (flowerType.equals("Gladiolus")) {
            price = 2.5 * flowerCount;
            if (flowerCount < 80)
                price += 0.2 * price;
        }

        double totalPrice = price - discount;
        double remainingBudget = budget - totalPrice;

        // Print the result
        if (remainingBudget >= 0) {
            System.out.printf("Hey, you have a great garden with %d %s and %.2f leva left.\n", flowerCount, flowerType, remainingBudget);
        } else {
            System.out.printf("Not enough money, you need %.2f leva more.\n", -remainingBudget);
        }

        scanner.close();
    }
}
