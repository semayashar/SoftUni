import java.util.Scanner;

public class E6 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int seaall = scanner.nextInt();
        int montall = scanner.nextInt();
        double profir = 0;
        String answer;

        do {
            answer = scanner.next();

            if (answer.equals("sea") && seaall > 0) {
                profir += 680;
                seaall--;
            } else if (answer.equals("mountain") && montall > 0) {
                profir += 499;
                montall--;
            }
        } while (!answer.equals("Stop") && (seaall > 0 || montall > 0));

        scanner.close();

        if (seaall == 0 && montall == 0) {
            System.out.println("Good job! Everything is sold.");
        }

        System.out.printf("Profit: %.0f leva.", profir);
    }
}
