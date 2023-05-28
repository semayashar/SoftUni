import java.util.Scanner;

public class NumberCheck {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number;

        System.out.print("Въведете число: ");
        number = scanner.nextInt();

        if (number >= -100 && number <= 100 && number != 0)
            System.out.println("Yes");
        else
            System.out.println("No");

        scanner.close();
    }
}
