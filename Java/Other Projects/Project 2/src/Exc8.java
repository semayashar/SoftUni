import java.util.Scanner;

public class Exc8 {
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        int dogs = Integer.parseInt(scanner.nextLine());
        int cats = Integer.parseInt(scanner.nextLine());
        double sum = (cats * 4) + (dogs * 2.50);
        System.out.println(sum + " lv.");
    }
}
