import java.util.Scanner;

public class ExamStatus {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int examHour = scanner.nextInt();
        int examMinute = scanner.nextInt();
        int arrivalHour = scanner.nextInt();
        int arrivalMinute = scanner.nextInt();

        int examTime = examHour * 60 + examMinute;
        int arrivalTime = arrivalHour * 60 + arrivalMinute;
        int difference = arrivalTime - examTime;

        String status;

        if (difference > 0) {
            status = "Late";
        } else if (difference >= -30) {
            status = "On time";
        } else {
            status = "Early";
        }

        int hours = Math.abs(difference) / 60;
        int minutes = Math.abs(difference) % 60;

        if (status.equals("Late") && hours == 0) {
            System.out.println(status);
            System.out.println(minutes + " minutes after the start");
        } else if (status.equals("Late") && hours > 0) {
            System.out.println(status);
            System.out.printf("%d:%02d hours after the start%n", hours, minutes);
        } else if (status.equals("On time") || (status.equals("Early") && hours >= 1)) {
            System.out.println(status);
        } else {
            System.out.println(status);
            System.out.println(minutes + " minutes before the start");
        }

        scanner.close();
    }
}
