import java.util.Scanner;
import java.text.DecimalFormat;

public class CinemaIncomeCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String projectionType;
        int rows, columns;
        double ticketPrice = 0.0;
        double income = 0.0;

        // Read input from the user
        System.out.print("Projection type: ");
        projectionType = scanner.next();
        System.out.print("Number of rows: ");
        rows = scanner.nextInt();
        System.out.print("Number of columns: ");
        columns = scanner.nextInt();

        // Calculate ticket price based on projection type
        if (projectionType.equals("Premiere")) {
            ticketPrice = 12.00;
        } else if (projectionType.equals("Normal")) {
            ticketPrice = 7.50;
        } else if (projectionType.equals("Discount")) {
            ticketPrice = 5.00;
        } else {
            System.out.println("Invalid projection type.");
            scanner.close();
            return;
        }

        // Calculate total income
        income = rows * columns * ticketPrice;

        // Print the result
        DecimalFormat df = new DecimalFormat("0.00");
        System.out.println("Total income: " + df.format(income) + " leva");

        scanner.close();
    }
}
