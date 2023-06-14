#include <iostream>

int main() {
    int number;

    std::cout << "Въведете число: ";
    std::cin >> number;

    if (number >= -100 && number <= 100 && number != 0)
        std::cout << "Yes\n";
    else
        std::cout << "No\n";

    return 0;
}
