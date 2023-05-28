#include <iostream>
#include <string>
#include <iomanip>

int main() {
    int days;
    std::string roomType, rating;
    std::cin >> days >> roomType >> rating;

    double price = 0;

    if (roomType == "room for one person") {
        price = (days - 1) * 18.00;
    }
    else if (roomType == "apartment") {
        price = (days - 1) * 25.00;
        if (days < 10) {
            price -= price * 0.3;
        }
        else if (days >= 10 && days <= 15) {
            price -= price * 0.35;
        }
        else {
            price -= price * 0.5;
        }
    }
    else if (roomType == "president apartment") {
        price = (days - 1) * 35.00;
        if (days < 10) {
            price -= price * 0.1;
        }
        else if (days >= 10 && days <= 15) {
            price -= price * 0.15;
        }
        else {
            price -= price * 0.2;
        }
    }

    if (rating == "positive") {
        price += price * 0.25;
    }
    else if (rating == "negative") {
        price -= price * 0.1;
    }

    std::cout << std::fixed << std::setprecision(2) << price << std::endl;

    return 0;
}
