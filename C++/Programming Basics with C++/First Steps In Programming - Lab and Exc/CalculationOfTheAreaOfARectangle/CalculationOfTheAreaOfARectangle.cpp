#include <iostream>

int main() {
    double sideA, sideB;
    std::cout << "Enter side a: ";
    std::cin >> sideA;
    std::cout << "Enter side b: ";
    std::cin >> sideB;
    double area = sideA * sideB;
    std::cout << "Area: " << area << std::endl;

    return 0;
}
