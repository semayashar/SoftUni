#include <iostream>
#include <iomanip>

int main() {
    double excursionPrice;
    int puzzles, dolls, teddyBears, minions, trucks;

    std::cin >> excursionPrice >> puzzles >> dolls >> teddyBears >> minions >> trucks;

    double puzzlePrice = 2.60;
    double dollPrice = 3.00;
    double teddyBearPrice = 4.10;
    double minionPrice = 8.20;
    double truckPrice = 2.00;

    int totalToys = puzzles + dolls + teddyBears + minions + trucks;
    double totalPrice = puzzles * puzzlePrice + dolls * dollPrice + teddyBears * teddyBearPrice +
        minions * minionPrice + trucks * truckPrice;

    if (totalToys >= 50) {
        totalPrice -= totalPrice * 0.25;
    }

    totalPrice -= totalPrice * 0.10;

    double profit = totalPrice - excursionPrice;

    if (profit >= 0) {
        std::cout << "Yes! " << std::fixed << std::setprecision(2) << profit << " lv left." << std::endl;
    }
    else {
        std::cout << "Not enough money! " << std::fixed << std::setprecision(2) << std::abs(profit) << " lv needed." << std::endl;
    }

    return 0;
}
