/*import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.nio.file.FileStore;

class LineData {
    private Point startPoint;
    private Point endPoint;

    public LineData() {
        this.startPoint = new Point(0, 0);
        this.endPoint = new Point(0, 0);
    }

    public LineData(Point startPoint, Point endPoint) {
        this.startPoint = startPoint;
        this.endPoint = endPoint;
    }

    public Point getStartPoint() {
        return startPoint;
    }

    public Point getEndPoint() {
        return endPoint;
    }

    public void setStartPoint(Point p) {
        startPoint.x = p.x;
        startPoint.y = p.y;
    }

    public void setEndPoint(Point p) {
        endPoint.x = p.x;
        endPoint.y = p.y;
    }
}
class DrawingPanel extends JPanel {
    private LineData[] lines;
    private int currentIndex;

    private class MyMouseListener extends MouseAdapter {
        LineData currentLine;

        @Override
        public void mousePressed(MouseEvent e) {
            currentLine = new LineData();
            currentLine.setStartPoint(e.getPoint());
        }

        @Override
        public void mouseReleased(MouseEvent e) {
            currentLine.setEndPoint(e.getPoint());
            lines[currentIndex++] = currentLine;
            repaint();
            printLinesCoordinates(currentLine);
            checkForIntersections(); // Check for intersections after drawing each line
        }

        @Override
        public void mouseDragged(MouseEvent e) {
            // You can update the end point while dragging if needed
            currentLine.setEndPoint(e.getPoint());
            repaint();
        }
    }

    public void printLinesCoordinates(LineData currentLine) {

            System.out.println("Line " + (currentIndex) +
                    ": Start(" + currentLine.getStartPoint().x + ", " + currentLine.getStartPoint().y +
                    "), End(" + currentLine.getEndPoint().x + ", " + currentLine.getEndPoint().y + ")");
    }
    public DrawingPanel(int maxSize) {
        lines = new LineData[maxSize];
        currentIndex = 0;

        MyMouseListener mouseListener = new MyMouseListener();
        addMouseListener(mouseListener);
        addMouseMotionListener(mouseListener);

    }

    @Override
    public void paint(Graphics g) {
        super.paint(g);

        for (int i = 0; i < currentIndex; i++) {
            g.drawLine(lines[i].getStartPoint().x,
                    lines[i].getStartPoint().y,
                    lines[i].getEndPoint().x,
                    lines[i].getEndPoint().y);
        }
    }

    public LineData[] getLines() {
        return lines;
    }

    static boolean doLinesIntersect(LineData FirstLine,LineData SecondLine) {

        double x1 = FirstLine.getStartPoint().x;
        double y1 = FirstLine.getStartPoint().y;
        double x2 = FirstLine.getEndPoint().x;
        double y2 = FirstLine.getEndPoint().y;

        double x3 = SecondLine.getStartPoint().x;
        double y3 = SecondLine.getStartPoint().y;
        double x4 = SecondLine.getEndPoint().x;
        double y4 = SecondLine.getEndPoint().y;

        // Calculate slopes
        double m1 = (y2 - y1) / (x2 - x1);
        double m2 = (y4 - y3) / (x4 - x3);

        // Check if the lines are parallel
        if (m1 == m2) {
            // Lines are either parallel or coincident
            return false;
        }

        // Calculate intersection point
        double intersectionX = (m1 * x1 - m2 * x3 + y3 - y1) / (m1 - m2);
        double intersectionY = m1 * (intersectionX - x1) + y1;

        // Check if the intersection point is within the line segments
        boolean withinLine1 = isPointWithinLineSegment(intersectionX, intersectionY, x1, y1, x2, y2);
        boolean withinLine2 = isPointWithinLineSegment(intersectionX, intersectionY, x3, y3, x4, y4);

        return withinLine1 && withinLine2;
    }

    static boolean isPointWithinLineSegment(double x, double y, double x1, double y1, double x2, double y2) {
        return (x >= Math.min(x1, x2) && x <= Math.max(x1, x2) &&
                y >= Math.min(y1, y2) && y <= Math.max(y1, y2));
    }
    public void checkForIntersections(Graphics g) {
        for (int i = 0; i < currentIndex - 1; i++) {
            for (int j = i + 1; j < currentIndex; j++) {
                LineData line1 = lines[i];
                LineData line2 = lines[j];

                if (doLinesIntersect(line1, line2)) {
                    System.out.println("Lines " + (i + 1) + " and " + (j + 1) + " intersect.");
                    g.drawLine(x1, y1, x3, y3);
                    g.drawLine(x3, y3, x2, y2);
                    g.drawLine(x2, y2, x4, y4);
                    g.drawLine(x4, y4, x1, y1);
                }
            }
        }
    }
}



public class DrawAndSaveLinesApp {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("Draw and Save Lines App");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setSize(400, 400);

            DrawingPanel drawingPanel = new DrawingPanel(10);

            frame.getContentPane().setLayout(new BorderLayout());
            frame.getContentPane().add(drawingPanel, BorderLayout.CENTER);

            frame.setVisible(true);
        });
    }
}
*/