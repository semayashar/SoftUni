import java.util.Scanner;

public class ShapeArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String shape = scanner.nextLine();

        double area = 0;

        if (shape.equals("square")) {
            double side = scanner.nextDouble();
            area = side * side;
        } else if (shape.equals("rectangle")) {
            double width = scanner.nextDouble();
            double height = scanner.nextDouble();
            area = width * height;
        } else if (shape.equals("circle")) {
            double radius = scanner.nextDouble();
            area = Math.PI * radius * radius;
        } else if (shape.equals("triangle")) {
            double base = scanner.nextDouble();
            double height = scanner.nextDouble();
            area = (base * height) / 2;
        }

        System.out.printf("%.3f", area);
    }
}
