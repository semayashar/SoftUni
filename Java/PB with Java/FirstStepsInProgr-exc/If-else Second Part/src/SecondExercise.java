import java.util.Scanner;

public class SecondExercise {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        int input = Integer.parseInt(scan.nextLine());
        double bonus = 0;
        if (input <= 100)
        {
            bonus = 5;
        }
        else if (input > 100){
            bonus += (input * 0.2);
        }
        else if (input > 1000){
            bonus += (input * 0.1);
        }

        if (input % 2 == 0)
        {
            bonus += 1;
        }
        if (input % 10 == 5) {
            bonus += 5;
        }
        System.out.println(bonus);
        System.out.println(input+bonus);
    }
}
