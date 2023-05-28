import java.util.Scanner;
import java.text.DecimalFormat;

public class CommissionCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String city;
        double salesVolume;

        city = scanner.next();
        salesVolume = scanner.nextDouble();

        double commission = -1.0; // Default value to indicate invalid commission

        if (city.equals("Sofia")) {
            if (salesVolume >= 0 && salesVolume <= 500) {
                commission = 0.05 * salesVolume;
            } else if (salesVolume > 500 && salesVolume <= 1000) {
                commission = 0.07 * salesVolume;
            } else if (salesVolume > 1000 && salesVolume <= 10000) {
                commission = 0.08 * salesVolume;
            } else if (salesVolume > 10000) {
                commission = 0.12 * salesVolume;
            }
        } else if (city.equals("Varna")) {
            if (salesVolume >= 0 && salesVolume <= 500) {
                commission = 0.045 * salesVolume;
            } else if (salesVolume > 500 && salesVolume <= 1000) {
                commission = 0.075 * salesVolume;
            } else if (salesVolume > 1000 && salesVolume <= 10000) {
                commission = 0.1 * salesVolume;
            } else if (salesVolume > 10000) {
                commission = 0.13 * salesVolume;
            }
        } else if (city.equals("Plovdiv")) {
            if (salesVolume >= 0 && salesVolume <= 500) {
                commission = 0.055 * salesVolume;
            } else if (salesVolume > 500 && salesVolume <= 1000) {
                commission = 0.08 * salesVolume;
            } else if (salesVolume > 1000 && salesVolume <= 10000) {
                commission = 0.12 * salesVolume;
            } else if (salesVolume > 10000) {
                commission = 0.145 * salesVolume;
            }
        }

        if (commission != -1.0) {
            DecimalFormat df = new DecimalFormat("0.00");
            System.out.println(df.format(commission));
        } else {
            System.out.println("error");
        }

        scanner.close();
    }
}
