
    import java.util.Scanner;

    public class E3 {
        public static void main(String[] args) {
            Scanner scanner = new Scanner(System.in);

            int days = Integer.parseInt(scanner.nextLine());
            String room = scanner.nextLine();
            String rate = scanner.nextLine();

            days = days - 1;
            double all;

            if (room.equals("room for one preson")) {
                all = days * 18;

            } else if (room.equals("apartment")) {
                all = days * 25;
                if (days <= 10) {
                    all = all - all * 0.30;
                } else if (days > 10 && days < 15) {
                    all = all - all * 0.35;
                } else {
                    all = all - all * 0.50;
                }
            } else {
                all = days * 35;
                if (days <= 10) {
                    all = all - all * 0.10;
                } else if (days > 10 && days < 15) {
                    all = all - all * 0.15;
                } else {
                    all = all - all * 0.20;
                }
            }

            if (rate.equals("positive")) {
                all = all + (all * 0.25);
            } else {
                all = all - (all * 0.10);
            }

            System.out.printf("%.2f", all);

            scanner.close();
        }

}
