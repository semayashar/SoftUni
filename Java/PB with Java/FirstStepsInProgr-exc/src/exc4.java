import java.util.Scanner;

public class exc4 {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        int count = Integer.parseInt(scan.nextLine());
        double pages = Double.parseDouble(scan.nextLine());
        int days = Integer.parseInt(scan.nextLine());
        double result = count/ pages/ days;
        System.out.println(Math.floor(result));
    }
}
