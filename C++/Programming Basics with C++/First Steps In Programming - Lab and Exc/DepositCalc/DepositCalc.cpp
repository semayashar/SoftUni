#include <iostream>

int main() {
    double depositedAmount, annualInterestRate, totalAmount;
    int depositPeriod;

    std::cout << "Депозирана сума: ";
    std::cin >> depositedAmount;

    std::cout << "Срок на депозита (в месеци): ";
    std::cin >> depositPeriod;

    std::cout << "Годишен лихвен процент: ";
    std::cin >> annualInterestRate;

    double monthlyInterestRate = annualInterestRate / 100 / 12;
    double accruedInterest = depositedAmount * monthlyInterestRate * depositPeriod;
    totalAmount = depositedAmount + accruedInterest;

    std::cout << "Сума в края на срока: " << totalAmount << std::endl;

    return 0;
}
