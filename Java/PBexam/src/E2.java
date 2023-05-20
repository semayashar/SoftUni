
    import java.util.Scanner;

    public class E2 {
        public static void main(String[] args) {
            Scanner scanner = new Scanner(System.in);

            double tshirt = scanner.nextDouble();
            double wonBall = scanner.nextDouble();
            double shorts = tshirt * 0.75;
            double socks = shorts * 0.20;
            double butonki = (tshirt + shorts) * 2;
            double all = tshirt + shorts + socks + butonki;
            all = all - (all * 0.15);

            if (all >= wonBall) {
                System.out.printf("Yes, he will earn the world-cup replica ball!\nHis sum is %.2f lv.", all);
            } else {
                System.out.printf("No, he will not earn the world-cup replica ball.\nHe needs %.2f lv. more.", wonBall - all);
            }

            scanner.close();
        }
    }

