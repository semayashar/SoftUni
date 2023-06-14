#include <iostream>
#include <iomanip>
#include <string>

int main() {
    std::string city;
    double salesVolume;
    std::cin >> city >> salesVolume;

    double commission = -1.0; // по подразбиране задаваме невалидна стойност на комисионната

    if (city == "Sofia") {
        if (salesVolume >= 0 && salesVolume <= 500) {
            commission = 0.05 * salesVolume;
        }
        else if (salesVolume > 500 && salesVolume <= 1000) {
            commission = 0.07 * salesVolume;
        }
        else if (salesVolume > 1000 && salesVolume <= 10000) {
            commission = 0.08 * salesVolume;
        }
        else if (salesVolume > 10000) {
            commission = 0.12 * salesVolume;
        }
    }
    else if (city == "Varna") {
        if (salesVolume >= 0 && salesVolume <= 500) {
            commission = 0.045 * salesVolume;
        }
        else if (salesVolume > 500 && salesVolume <= 1000) {
            commission = 0.075 * salesVolume;
        }
        else if (salesVolume > 1000 && salesVolume <= 10000) {
            commission = 0.1 * salesVolume;
        }
        else if (salesVolume > 10000) {
            commission = 0.13 * salesVolume;
        }
    }
    else if (city == "Plovdiv") {
        if (salesVolume >= 0 && salesVolume <= 500) {
            commission = 0.055 * salesVolume;
        }
        else if (salesVolume > 500 && salesVolume <= 1000) {
            commission = 0.08 * salesVolume;
        }
        else if (salesVolume > 1000 && salesVolume <= 10000) {
            commission = 0.12 * salesVolume;
        }
        else if (salesVolume > 10000) {
            commission = 0.145 * salesVolume;
        }
    }

    if (commission != -1.0) {
        std::cout << std::fixed << std::setprecision(2) << commission;
    }
    else {
        std::cout << "error";
    }

    return 0;
}
