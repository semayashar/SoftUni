#include <iostream>
#include <iomanip> // За използване на setprecision()

int main() {
    double usd, bgn;
    const double exchangeRate = 1.79549;

    std::cout << "Въведете сума в USD: ";
    std::cin >> usd;

    bgn = usd * exchangeRate;

    std::cout << "Сума в BGN: " << std::fixed << std::setprecision(2) << bgn << std::endl;

    return 0;
}
