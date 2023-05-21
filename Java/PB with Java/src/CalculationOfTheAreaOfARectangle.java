import java.util.Scanner;

public class CalculationOfTheAreaOfARectangle {
    public static void main(String[] args) {
        double sideA, sideB;
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter side a: ");
        sideA = Double.parseDouble(scanner.nextLine());
        System.out.print("Enter side b: ");
        sideB = Double.parseDouble(scanner.nextLine());
        double area = sideA * sideB;
        System.out.println("Area: " + area);
    }
}
