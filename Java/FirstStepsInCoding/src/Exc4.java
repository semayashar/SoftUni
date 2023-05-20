import java.awt.desktop.SystemEventListener;
import java.util.Scanner;

public class Exc4 {
    public static void main(String[] args){
        //по 2.54 (1 инч = 2.54 сантиметра).
        Scanner scan = new Scanner(System.in);
        double cm = Double.parseDouble(scan.nextLine()) * 2.54;
        System.out.println(cm);
    }
}
