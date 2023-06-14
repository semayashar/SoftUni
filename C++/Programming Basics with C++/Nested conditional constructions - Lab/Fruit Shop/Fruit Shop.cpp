﻿#include <iostream>
#include <string>
#include <iomanip>

int main() {
    std::string fruit;
    std::string day;
    double quantity;

    std::cin >> fruit >> day >> quantity;

    double price = 0.0;

    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") {
        if (fruit == "banana") {
            price = 2.50;
        }
        else if (fruit == "apple") {
            price = 1.20;
        }
        else if (fruit == "orange") {
            price = 0.85;
        }
        else if (fruit == "grapefruit") {
            price = 1.45;
        }
        else if (fruit == "kiwi") {
            price = 2.70;
        }
        else if (fruit == "pineapple") {
            price = 5.50;
        }
        else if (fruit == "grapes") {
            price = 3.85;
        }
    }
    else if (day == "Saturday" || day == "Sunday") {
        if (fruit == "banana") {
            price = 2.70;
        }
        else if (fruit == "apple") {
            price = 1.25;
        }
        else if (fruit == "orange") {
            price = 0.90;
        }
        else if (fruit == "grapefruit") {
            price = 1.60;
        }
        else if (fruit == "kiwi") {
            price = 3.00;
        }
        else if (fruit == "pineapple") {
            price = 5.60;
        }
        else if (fruit == "grapes") {
            price = 4.20;
        }
    }

    if (price > 0.0) {
        double total = price * quantity;
        std::cout << std::fixed << std::setprecision(2) << total;
    }
    else {
        std::cout << "error";
    }

    return 0;
}
