import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        double usd =  1.79549;
        Scanner scan = new Scanner(System.in);
        double leva = Double.parseDouble(scan.nextLine()) * usd;
        System.out.println(leva);
    }
}