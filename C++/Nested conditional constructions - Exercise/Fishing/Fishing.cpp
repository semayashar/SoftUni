#include <iostream>
#include <string>
#include <iomanip>

int main() {
    int budget;
    std::string season;
    int fishermenCount;
    double price = 0;

    // Read input from the user
    std::cout << "Budget: ";
    std::cin >> budget;
    std::cout << "Season: ";
    std::cin >> season;
    std::cout << "Fishermen count: ";
    std::cin >> fishermenCount;

    // Calculate the price based on the season and fishermen count
    if (season == "Spring") {
        price = 3000;
    }
    else if (season == "Summer" || season == "Autumn") {
        price = 4200;
    }
    else if (season == "Winter") {
        price = 2600;
    }

    // Apply discount based on the fishermen count
    if (fishermenCount <= 6) {
        price -= 0.1 * price;
    }
    else if (fishermenCount <= 11) {
        price -= 0.15 * price;
    }
    else if (fishermenCount >= 12) {
        price -= 0.25 * price;
    }

    // Check if additional discount applies for even number of fishermen (except for Autumn)
    if (season != "Autumn" && fishermenCount % 2 == 0) {
        price -= 0.05 * price;
    }

    double remainingBudget = budget - price;

    // Print the result
    if (remainingBudget >= 0) {
        std::cout << "Yes! You have " << std::fixed << std::setprecision(2) << remainingBudget << " leva left." << std::endl;
    }
    else {
        std::cout << "Not enough money! You need " << std::fixed << std::setprecision(2) << -remainingBudget << " leva." << std::endl;
    }

    return 0;
}
