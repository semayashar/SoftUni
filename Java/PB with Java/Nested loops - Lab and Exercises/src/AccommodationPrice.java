import java.util.Scanner;

public class AccommodationPrice {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String month = scanner.next();
        int nights = scanner.nextInt();

        double studioPrice = 0.0;
        double apartmentPrice = 0.0;

        if (month.equals("May") || month.equals("October")) {
            studioPrice = 50.0;
            apartmentPrice = 65.0;

            if (nights > 14) {
                studioPrice -= studioPrice * 0.3;
            } else if (nights > 7) {
                studioPrice -= studioPrice * 0.05;
            }
        } else if (month.equals("June") || month.equals("September")) {
            studioPrice = 75.20;
            apartmentPrice = 68.70;

            if (nights > 14) {
                studioPrice -= studioPrice * 0.2;
            }
        } else if (month.equals("July") || month.equals("August")) {
            studioPrice = 76.0;
            apartmentPrice = 77.0;
        }

        studioPrice *= nights;
        apartmentPrice *= nights;

        if (nights > 14) {
            apartmentPrice -= apartmentPrice * 0.1;
        }

        System.out.printf("Apartment: %.2f lv.%n", apartmentPrice);
        System.out.printf("Studio: %.2f lv.%n", studioPrice);

        scanner.close();
    }
}
