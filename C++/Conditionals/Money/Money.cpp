#include <iostream>
#include <iomanip>

int main() {
    double budget, videoCardPrice, processorPrice, ramPrice;
    int videoCardCount, processorCount, ramCount;

    std::cin >> budget >> videoCardCount >> processorCount >> ramCount;

    videoCardPrice = videoCardCount * 250.0;
    processorPrice = processorCount * (0.35 * videoCardPrice);
    ramPrice = ramCount * (0.1 * videoCardPrice);

    if (videoCardCount > processorCount) {
        double discount = 0.15 * (videoCardPrice + processorPrice + ramPrice);
        double totalPrice = videoCardPrice + processorPrice + ramPrice - discount;

        if (totalPrice <= budget) {
            double remainingMoney = budget - totalPrice;
            std::cout << "You have " << std::fixed << std::setprecision(2) << remainingMoney << " leva left!" << std::endl;
        }
        else {
            double neededMoney = totalPrice - budget;
            std::cout << "Not enough money! You need " << std::fixed << std::setprecision(2) << neededMoney << " leva more!" << std::endl;
        }
    }
    else {
        double totalPrice = videoCardPrice + processorPrice + ramPrice;

        if (totalPrice <= budget) {
            double remainingMoney = budget - totalPrice;
            std::cout << "You have " << std::fixed << std::setprecision(2) << remainingMoney << " leva left!" << std::endl;
        }
        else {
            double neededMoney = totalPrice - budget;
            std::cout << "Not enough money! You need " << std::fixed << std::setprecision(2) << neededMoney << " leva more!" << std::endl;
        }
    }

    return 0;
}
