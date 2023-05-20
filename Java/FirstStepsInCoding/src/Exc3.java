import java.util.Scanner;

public class Exc3 {
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        int a = Integer.parseInt(scanner.nextLine());
        int b = Integer.parseInt(scanner.nextLine());
        int surface = a*b;
        System.out.println(surface);
    }
}
