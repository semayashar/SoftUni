import java.util.Scanner;

public class PersonTitle {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double age;
        char gender;

        System.out.print("Enter the age: ");
        age = scanner.nextDouble();

        System.out.print("Enter the gender ('m' or 'f'): ");
        gender = scanner.next().charAt(0);

        if (gender == 'm') {
            if (age >= 16)
                System.out.println("Mr.");
            else
                System.out.println("Master");
        } else if (gender == 'f') {
            if (age >= 16)
                System.out.println("Ms.");
            else
                System.out.println("Miss");
        }

        scanner.close();
    }
}
