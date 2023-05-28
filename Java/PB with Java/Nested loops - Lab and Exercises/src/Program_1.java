import java.util.Scanner;

public class Program_1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String animalName;

        System.out.print("Enter the name of the animal: ");
        animalName = scanner.next();

        if (animalName.equals("dog"))
            System.out.println("mammal");
        else if (animalName.equals("crocodile") || animalName.equals("tortoise") || animalName.equals("snake"))
            System.out.println("reptile");
        else
            System.out.println("unknown");

        scanner.close();
    }
}
