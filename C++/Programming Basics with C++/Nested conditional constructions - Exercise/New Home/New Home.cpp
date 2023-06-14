#include <iostream>
#include <string>
#include <iomanip>

int main() {
    std::string flowerType;
    int flowerCount;
    int budget;
    double price = 0;
    double discount = 0;

    // Read input from the user
    std::cout << "Flower type: ";
    std::cin >> flowerType;
    std::cout << "Flower count: ";
    std::cin >> flowerCount;
    std::cout << "Budget: ";
    std::cin >> budget;

    // Calculate the price based on the flower type and count
    if (flowerType == "Roses") {
        price = 5.0 * flowerCount;
        if (flowerCount > 80)
            discount = 0.1 * price;
    }
    else if (flowerType == "Dahlias") {
        price = 3.8 * flowerCount;
        if (flowerCount > 90)
            discount = 0.15 * price;
    }
    else if (flowerType == "Tulips") {
        price = 2.8 * flowerCount;
        if (flowerCount > 80)
            discount = 0.15 * price;
    }
    else if (flowerType == "Narcissus") {
        price = 3.0 * flowerCount;
        if (flowerCount < 120)
            price += 0.15 * price;
    }
    else if (flowerType == "Gladiolus") {
        price = 2.5 * flowerCount;
        if (flowerCount < 80)
            price += 0.2 * price;
    }

    double totalPrice = price - discount;
    double remainingBudget = budget - totalPrice;

    // Print the result
    if (remainingBudget >= 0) {
        std::cout << "Hey, you have a great garden with " << flowerCount << " " << flowerType << " and "
            << std::fixed << std::setprecision(2) << remainingBudget << " leva left." << std::endl;
    }
    else {
        std::cout << "Not enough money, you need " << std::fixed << std::setprecision(2) << -remainingBudget
            << " leva more." << std::endl;
    }

    return 0;
}
