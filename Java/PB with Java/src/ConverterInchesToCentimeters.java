import java.util.Scanner;

public class ConverterInchesToCentimeters {
    public static void main(String[] args) {

        double cm, inch;
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter inches: ");
        inch = Double.parseDouble(scanner.nextLine());
        cm = inch * 2.54;
        System.out.print("Centimeters: " + cm);
    }
}

