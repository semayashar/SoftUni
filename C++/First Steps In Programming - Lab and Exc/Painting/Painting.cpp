#include <iostream>
#include <iomanip>

int main() {
    int nylonArea, paintLiters, thinnerLiters, hoursOfWork;
    double nylonPricePerSqMeter = 1.50;
    double paintPricePerLiter = 14.50;
    double thinnerPricePerLiter = 5.00;
    double plasticBagsPrice = 0.40;
    double laborCostPercentage = 0.30;

    std::cout << "Необходимо количество найлон (в кв.м.): ";
    std::cin >> nylonArea;

    std::cout << "Необходимо количество боя (в литри): ";
    std::cin >> paintLiters;

    std::cout << "Количество разредител (в литри): ";
    std::cin >> thinnerLiters;

    std::cout << "Часове работа: ";
    std::cin >> hoursOfWork;

    // Calculate material costs
    double additionalNylon = 2.0; // 2 sq. meters
    double additionalPaint = paintLiters * 0.10; // 10% of the required paint
    double nylonCost = (nylonArea + additionalNylon) * nylonPricePerSqMeter;
    double paintCost = (paintLiters + additionalPaint) * paintPricePerLiter;
    double thinnerCost = thinnerLiters * thinnerPricePerLiter;
    double plasticBagsCost = plasticBagsPrice;

    double totalMaterialCost = nylonCost + paintCost + thinnerCost + plasticBagsCost;

    // Calculate labor cost
    double laborCost = totalMaterialCost * laborCostPercentage * hoursOfWork;

    // Calculate total cost
    double totalCost = totalMaterialCost + laborCost;

    std::cout << "Сума за плащане: " << std::fixed << std::setprecision(2) << totalCost << " лв." << std::endl;

    return 0;
}
