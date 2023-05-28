#include <iostream>
#include <string>

int main() {
    int hour;
    std::string day;

    std::cin >> hour >> day;

    if (day == "Saturday" || day == "Sunday") {
        std::cout << "closed";
    }
    else if (hour >= 10 && hour <= 18) {
        std::cout << "open";
    }
    else {
        std::cout << "closed";
    }

    return 0;
}
