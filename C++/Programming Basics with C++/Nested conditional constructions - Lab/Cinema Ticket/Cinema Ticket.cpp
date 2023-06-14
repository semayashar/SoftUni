#include <iostream>
#include <string>

int main() {
    std::string day;
    std::cin >> day;

    int price;

    if (day == "Monday" || day == "Tuesday" || day == "Friday") {
        price = 12;
    }
    else if (day == "Wednesday" || day == "Thursday") {
        price = 14;
    }
    else if (day == "Saturday" || day == "Sunday") {
        price = 16;
    }

    std::cout << price;

    return 0;
}
