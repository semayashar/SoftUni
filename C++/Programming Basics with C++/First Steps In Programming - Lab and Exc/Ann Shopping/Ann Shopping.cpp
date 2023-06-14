#include <iostream>
#include <iomanip>

int main() {
    int numPencilPacks, numMarkerPacks, litersCleaner;
    int discountPercentage;
    double pencilPackPrice = 5.80;
    double markerPackPrice = 7.20;
    double cleanerPricePerLiter = 1.20;
    double totalAmount, discountedAmount;

    std::cout << "Брой пакети химикали: ";
    std::cin >> numPencilPacks;

    std::cout << "Брой пакети маркери: ";
    std::cin >> numMarkerPacks;

    std::cout << "Литри препарат за почистване на дъска: ";
    std::cin >> litersCleaner;

    std::cout << "Процент намаление: ";
    std::cin >> discountPercentage;

    double pencilPackTotal = numPencilPacks * pencilPackPrice;
    double markerPackTotal = numMarkerPacks * markerPackPrice;
    double cleanerTotal = litersCleaner * cleanerPricePerLiter;

    totalAmount = pencilPackTotal + markerPackTotal + cleanerTotal;
    discountedAmount = totalAmount - (totalAmount * discountPercentage / 100);

    std::cout << "Сума за плащане: " << std::fixed << std::setprecision(2) << discountedAmount << " лв." << std::endl;

    return 0;
}
