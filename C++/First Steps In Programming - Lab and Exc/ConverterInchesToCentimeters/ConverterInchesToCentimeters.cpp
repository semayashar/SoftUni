#include <iostream>

int main() {
    double cm, inch;
    std::cout << "Enter inches: ";
    std::cin >> inch;
    cm = inch * 2.54;
    std::cout << "Centimeters: " << cm;

    return 0;
}
