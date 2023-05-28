import java.util.Scanner;

public class AccommodationPrice2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int days = scanner.nextInt();
        String roomType = scanner.next();
        String rating = scanner.next();

        double price = 0;

        if (roomType.equals("room for one person")) {
            price = (days - 1) * 18.00;
        } else if (roomType.equals("apartment")) {
            price = (days - 1) * 25.00;
            if (days < 10) {
                price -= price * 0.3;
            } else if (days >= 10 && days <= 15) {
                price -= price * 0.35;
            } else {
                price -= price * 0.5;
            }
        } else if (roomType.equals("president apartment")) {
            price = (days - 1) * 35.00;
            if (days < 10) {
                price -= price * 0.1;
            } else if (days >= 10 && days <= 15) {
                price -= price * 0.15;
            } else {
                price -= price * 0.2;
            }
        }

        if (rating.equals("positive")) {
            price += price * 0.25;
        } else if (rating.equals("negative")) {
            price -= price * 0.1;
        }

        System.out.printf("%.2f%n", price);

        scanner.close();
    }
}
