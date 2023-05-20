import java.util.Scanner;

public class E7{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int first = scanner.nextInt();
        int second = scanner.nextInt();
        int third = scanner.nextInt();

        for (int i = 1; i <= first; i++) {
            if (i % 2 == 0) {
                for (int y = 1; y <= second; y++) {
                    if (y == 2 || y == 3 || y == 5 || y == 7) {
                        for (int x = 1; x <= third; x++) {
                            if (x % 2 == 0) {
                                System.out.printf("%d %d %d%n", i, y, x);
                            }
                        }
                    }
                }
            }
        }
    }
}