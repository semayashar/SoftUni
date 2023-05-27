#define _USE_MATH_DEFINES
#include <iostream>
#include <cmath>
#include <iomanip>

int main() {
    std::string shape;
    std::cout << "Enter the shape: ";
    std::cin >> shape;

    double area;

    if (shape == "square") {
        double side;
        std::cout << "Enter the side length: ";
        std::cin >> side;
        area = side * side;
    }
    else if (shape == "rectangle") {
        double length, width;
        std::cout << "Enter the length: ";
        std::cin >> length;
        std::cout << "Enter the width: ";
        std::cin >> width;
        area = length * width;
    }
    else if (shape == "circle") {
        double radius;
        std::cout << "Enter the radius: ";
        std::cin >> radius;
        area = M_PI * radius * radius;
    }
    else if (shape == "triangle") {
        double base, height;
        std::cout << "Enter the base: ";
        std::cin >> base;
        std::cout << "Enter the height: ";
        std::cin >> height;
        area = 0.5 * base * height;
    }

    std::cout << "The area is: " << std::fixed << std::setprecision(3) << area << std::endl;

    return 0;
}
