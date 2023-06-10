import java.util.Scanner;

public class SalesCommission {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String city = scanner.nextLine();
        double sales = scanner.nextDouble();
        scanner.close();

        double commission = 0.0;

        if (sales >= 0 && sales <= 500) {
            switch (city) {
                case "Sofia":
                    commission = 0.05 * sales;
                    break;
                case "Varna":
                    commission = 0.045 * sales;
                    break;
                case "Plovdiv":
                    commission = 0.055 * sales;
                    break;
                default:
                    System.out.println("error");
                    return;
            }
        } else if (sales > 500 && sales <= 1000) {
            switch (city) {
                case "Sofia":
                    commission = 0.07 * sales;
                    break;
                case "Varna":
                    commission = 0.075 * sales;
                    break;
                case "Plovdiv":
                    commission = 0.08 * sales;
                    break;
                default:
                    System.out.println("error");
                    return;
            }
        } else if (sales > 1000 && sales <= 10000) {
            switch (city) {
                case "Sofia":
                    commission = 0.08 * sales;
                    break;
                case "Varna":
                    commission = 0.1 * sales;
                    break;
                case "Plovdiv":
                    commission = 0.12 * sales;
                    break;
                default:
                    System.out.println("error");
                    return;
            }
        } else if (sales > 10000) {
            switch (city) {
                case "Sofia":
                    commission = 0.12 * sales;
                    break;
                case "Varna":
                    commission = 0.13 * sales;
                    break;
                case "Plovdiv":
                    commission = 0.145 * sales;
                    break;
                default:
                    System.out.println("error");
                    return;
            }
        } else {
            System.out.println("error");
            return;
        }

        System.out.printf("%.2f", commission);
    }
}
