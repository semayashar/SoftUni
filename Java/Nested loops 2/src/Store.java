import java.util.Scanner;

public class Store {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String product = scanner.nextLine();
        String city = scanner.nextLine();
        double quantity = scanner.nextDouble();
        scanner.close();

        double price = 0.0;

        switch (city) {
            case "Sofia":
                switch (product) {
                    case "coffee":
                        price = 0.50;
                        break;
                    case "water":
                        price = 0.80;
                        break;
                    case "beer":
                        price = 1.20;
                        break;
                    case "sweets":
                        price = 1.45;
                        break;
                    case "peanuts":
                        price = 1.60;
                        break;
                }
                break;
            case "Plovdiv":
                switch (product) {
                    case "coffee":
                        price = 0.40;
                        break;
                    case "water":
                        price = 0.70;
                        break;
                    case "beer":
                        price = 1.15;
                        break;
                    case "sweets":
                        price = 1.30;
                        break;
                    case "peanuts":
                        price = 1.50;
                        break;
                }
                break;
            case "Varna":
                switch (product) {
                    case "coffee":
                        price = 0.45;
                        break;
                    case "water":
                        price = 0.70;
                        break;
                    case "beer":
                        price = 1.10;
                        break;
                    case "sweets":
                        price = 1.35;
                        break;
                    case "peanuts":
                        price = 1.55;
                        break;
                }
                break;
            default:
                System.out.println("Invalid city");
                return;
        }

        double total = price * quantity;
        System.out.printf("The total price of %s in %s is %.2f", product, city, total);
    }
}
