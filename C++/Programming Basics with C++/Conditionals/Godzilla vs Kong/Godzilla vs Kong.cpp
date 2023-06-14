#include <iostream>
#include <iomanip>

int main() {
    double budget, clothingPrice;
    int extras;

    std::cin >> budget >> extras >> clothingPrice;

    double decorPrice = budget * 0.10;
    double totalClothingPrice = extras * clothingPrice;

    if (extras > 150) {
        totalClothingPrice -= totalClothingPrice * 0.10;
    }

    double totalExpenses = decorPrice + totalClothingPrice;
    double remainingBudget = budget - totalExpenses;

    if (remainingBudget >= 0) {
        std::cout << "Action!" << std::endl;
        std::cout << "Wingard starts filming with " << std::fixed << std::setprecision(2) << remainingBudget << " leva left." << std::endl;
    }
    else {
        std::cout << "Not enough money!" << std::endl;
        std::cout << "Wingard needs " << std::fixed << std::setprecision(2) << std::abs(remainingBudget) << " leva more." << std::endl;
    }

    return 0;
}
