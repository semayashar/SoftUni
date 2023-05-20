import java.util.Scanner;

public class Exc9 {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        double all = Double.parseDouble(scan.nextLine()) * 7.61;
        double priceoff = all * 0.18;
        System.out.printf("The final price is: %.2f lv.\nThe discount is: %.2f lv.", all - priceoff, priceoff);
    }
}
