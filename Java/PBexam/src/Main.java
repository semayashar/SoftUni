import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);
        double prosPrice = Double.parseDouble(scanner.nextLine());
        double vidCPrice = Double.parseDouble(scanner.nextLine());
        double ramPrice =Double.parseDouble(scanner.nextLine());
        int countRam = Integer.parseInt(scanner.nextLine());
        double offPrice = Double.parseDouble(scanner.nextLine());

        double prosPricelv = prosPrice * 1.57;
        double vidCPricelv = vidCPrice * 1.57;

        prosPricelv =  prosPricelv - (prosPricelv * offPrice);
        vidCPricelv = vidCPricelv - (vidCPricelv * offPrice);

        double allinLV = prosPricelv + vidCPricelv + ((ramPrice * countRam) * 1.57);
        System.out.println("Money needed - " + String.format("%.2f", allinLV) + " leva.");
    }
}