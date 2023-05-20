import java.util.Scanner;

public class E4 {
    public static void main(String[] args) {
        /*Входът се чете от конзолата и съдържа точно 2 реда:
         На първия ред - цената на тениската – реално число в интервала [1.00 ... 1000.00]
         На втория ред - сумата, която трябва да достигне, за да спечели топка – реално число в интервала
        [100.00 ... 10 000.00]*/

        Scanner scanner = new Scanner(System.in);

        double tshirt = Double.parseDouble(scanner.nextLine());
        double wonBall = Double.parseDouble(scanner.nextLine());
        double shorts = tshirt * 0.75;
        double socks = shorts * 0.20;
        double butonki = (tshirt+shorts)*2;
        double all = tshirt + shorts + socks + butonki;
        all = all - (all * 0.15);

        if (all >= wonBall)
        {
            System.out.printf("Yes, he will earn the world-cup replica ball!\nHis sum is %.2f lv.", all);
        }
        else
        {
            System.out.printf("No, he will not earn the world-cup replica ball.\nHe needs %.2f lv. more.", wonBall - all);
        }
    }
}
