import java.util.Scanner;

public class BusinessHours {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int hour;
        String day;

        hour = scanner.nextInt();
        day = scanner.next();

        if (day.equals("Saturday") || day.equals("Sunday")) {
            System.out.println("closed");
        } else if (hour >= 10 && hour <= 18) {
            System.out.println("open");
        } else {
            System.out.println("closed");
        }

        scanner.close();
    }
}
