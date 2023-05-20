import java.util.Scanner;

public class FirstExercise {
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        int sec = 0;
        int min = 0;
        for (int i = 0; i<3;i++){
            sec += Integer.parseInt(scan.nextLine());
            while (sec > 60){
                min++;
                sec = sec - 60;
            }
        }
        if(sec<10) {
            System.out.printf("%d:0%d", min, sec);
        }
        else{
            System.out.printf("%d:%d", min, sec);
        }
    }
}