import java.util.Scanner;

public class OutfitSelector {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int degrees;
        String timeOfDay;
        String outfit = "";
        String shoes = "";

        // Read input from the user
        System.out.print("Degrees: ");
        degrees = scanner.nextInt();
        System.out.print("Time of day (Morning/Afternoon/Evening): ");
        timeOfDay = scanner.next();

        // Determine the outfit and shoes based on temperature and time of day
        if (degrees >= 10 && degrees <= 18) {
            if (timeOfDay.equals("Morning")) {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            } else if (timeOfDay.equals("Afternoon") || timeOfDay.equals("Evening")) {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        } else if (degrees > 18 && degrees <= 24) {
            if (timeOfDay.equals("Morning")) {
                outfit = "Shirt";
                shoes = "Moccasins";
            } else if (timeOfDay.equals("Afternoon")) {
                outfit = "T-Shirt";
                shoes = "Sandals";
            } else if (timeOfDay.equals("Evening")) {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        } else if (degrees >= 25) {
            if (timeOfDay.equals("Morning") || timeOfDay.equals("Afternoon")) {
                outfit = "T-Shirt";
                shoes = "Sandals";
            } else if (timeOfDay.equals("Evening")) {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }

        // Print the result
        System.out.println("It's " + degrees + " degrees, get your " + outfit + " and " + shoes + ".");

        scanner.close();
    }
}
