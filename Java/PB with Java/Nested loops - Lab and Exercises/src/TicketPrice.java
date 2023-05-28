import java.util.Scanner;

public class TicketPrice {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String day;
        int price = 0;

        day = scanner.next();

        if (day.equals("Monday") || day.equals("Tuesday") || day.equals("Friday")) {
            price = 12;
        } else if (day.equals("Wednesday") || day.equals("Thursday")) {
            price = 14;
        } else if (day.equals("Saturday") || day.equals("Sunday")) {
            price = 16;
        }

        System.out.println(price);

        scanner.close();
    }
}
