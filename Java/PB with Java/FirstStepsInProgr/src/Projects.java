import java.util.Scanner;

public class Projects {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter name: ");
        String firstName = scanner.nextLine();
        System.out.print("Enter projects: ");
        int projects = Integer.parseInt(scanner.nextLine());
        int hours = 3 * projects;

        System.out.printf("\"The architect %s will need %d hours to complete %d project/s.",
                firstName, hours, projects);
    }
}
