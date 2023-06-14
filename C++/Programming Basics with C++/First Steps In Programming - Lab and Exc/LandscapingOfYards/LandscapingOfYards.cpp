#include <iostream>

int main() {
    int area;
    std::cout << "Area: ";
    std::cin >> area;

    double price = (7.61 * area) - ((7.61 * area) * 0.18);
    double discount = ((7.61 * area) * 0.18);

    std::cout << "The final price is: " << price << std::endl;
    std::cout << "The discount is: " << discount << std::endl;

    return 0;
}
