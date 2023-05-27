#include <iostream>

int main() {
    int number;
    std::cout << "Enter an integer: ";
    std::cin >> number;

    if (number < 100) {
        std::cout << "Less than 100" << std::endl;
    }
    else if (number <= 200) {
        std::cout << "Between 100 and 200" << std::endl;
    }
    else {
        std::cout << "Greater than 200" << std::endl;
    }

    return 0;
}
