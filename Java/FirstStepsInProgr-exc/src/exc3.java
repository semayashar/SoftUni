import java.util.Scanner;

public class exc3 {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        double deposit = Double.parseDouble(scan.nextLine());
        int time = Integer.parseInt(scan.nextLine());
        double proc = Double.parseDouble(scan.nextLine());
        double sum = deposit + time * ((deposit * (proc/100)) / 12);
        System.out.println(sum);
    }
}
