import java.util.Scanner;

public class PetStore {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter count of dog food packages: ");
        int countForDogs = Integer.parseInt(scanner.nextLine());
        System.out.print("Enter count of cat food packages: ");
        int countForCats = Integer.parseInt(scanner.nextLine());
        double priceForDogs = 2.50 * countForDogs;
        double priceForCats = 4 * countForCats;
        double sum = priceForDogs + priceForCats;
        System.out.print("The sum is $" + sum);
    }
}
