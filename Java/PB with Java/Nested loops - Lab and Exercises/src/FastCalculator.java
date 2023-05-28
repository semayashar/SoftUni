import java.util.Scanner;

public class FastCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int N1 = scanner.nextInt();
        int N2 = scanner.nextInt();
        char oper = scanner.next().charAt(0);

        double result;
        String resultType;

        switch (oper) {
            case '+':
                result = N1 + N2;
                resultType = (result % 2 == 0) ? "even" : "odd";
                System.out.printf("%d + %d = %.0f - %s%n", N1, N2, result, resultType);
                break;
            case '-':
                result = N1 - N2;
                resultType = (result % 2 == 0) ? "even" : "odd";
                System.out.printf("%d - %d = %.0f - %s%n", N1, N2, result, resultType);
                break;
            case '*':
                result = N1 * N2;
                resultType = (result % 2 == 0) ? "even" : "odd";
                System.out.printf("%d * %d = %.0f - %s%n", N1, N2, result, resultType);
                break;
            case '/':
                if (N2 != 0) {
                    result = (double) N1 / N2;
                    System.out.printf("%d / %d = %.2f%n", N1, N2, result);
                } else {
                    System.out.println("Cannot divide " + N1 + " by zero");
                }
                break;
            case '%':
                if (N2 != 0) {
                    result = N1 % N2;
                    System.out.printf("%d %% %d = %.0f%n", N1, N2, result);
                } else {
                    System.out.println("Cannot divide " + N1 + " by zero");
                }
                break;
            default:
                System.out.println("Invalid operator");
        }

        scanner.close();
    }
}
