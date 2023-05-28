#include <iostream>
#include <string>

int main() {
    std::string product;
    std::string city;
    double quantity;
    double price = 0.0;

    std::cout << "Enter the product: ";
    std::cin >> product;

    std::cout << "Enter the city: ";
    std::cin >> city;

    std::cout << "Enter the quantity: ";
    std::cin >> quantity;

    if (city == "Sofia") {
        if (product == "coffee")
            price = 0.50;
        else if (product == "water")
            price = 0.80;
        else if (product == "beer")
            price = 1.20;
        else if (product == "sweets")
            price = 1.45;
        else if (product == "peanuts")
            price = 1.60;
    }
    else if (city == "Plovdiv") {
        if (product == "coffee")
            price = 0.40;
        else if (product == "water")
            price = 0.70;
        else if (product == "beer")
            price = 1.15;
        else if (product == "sweets")
            price = 1.30;
        else if (product == "peanuts")
            price = 1.50;
    }
    else if (city == "Varna") {
        if (product == "coffee")
            price = 0.45;
        else if (product == "water")
            price = 0.70;
        else if (product == "beer")
            price = 1.10;
        else if (product == "sweets")
            price = 1.35;
        else if (product == "peanuts")
            price = 1.55;
    }

    double totalCost = quantity * price;
    std::cout << "The total cost is: " << totalCost << std::endl;

    return 0;
}
