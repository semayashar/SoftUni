import java.util.Scanner;

public class LandscapingOfYards {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Area: ");
        int area = Integer.parseInt(scanner.nextLine());
        double price = (7.61 * area) - ((7.61 * area) * 0.18);
        double discount = ((7.61 * area) * 0.18);
        System.out.println("The final price is: " + price);
        System.out.println("The discount is: " + discount);
    }
}
