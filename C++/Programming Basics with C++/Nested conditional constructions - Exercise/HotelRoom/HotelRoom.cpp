#include <iostream>
#include <string>
#include <iomanip>

int main() {
    std::string month;
    int nights;
    std::cin >> month >> nights;

    double studioPrice = 0.0;
    double apartmentPrice = 0.0;

    if (month == "May" || month == "October") {
        studioPrice = 50.0;
        apartmentPrice = 65.0;

        if (nights > 14) {
            studioPrice -= studioPrice * 0.3;
        }
        else if (nights > 7) {
            studioPrice -= studioPrice * 0.05;
        }
    }
    else if (month == "June" || month == "September") {
        studioPrice = 75.20;
        apartmentPrice = 68.70;

        if (nights > 14) {
            studioPrice -= studioPrice * 0.2;
        }
    }
    else if (month == "July" || month == "August") {
        studioPrice = 76.0;
        apartmentPrice = 77.0;
    }

    studioPrice *= nights;
    apartmentPrice *= nights;

    if (nights > 14) {
        apartmentPrice -= apartmentPrice * 0.1;
    }

    std::cout << "Apartment: " << std::fixed << std::setprecision(2) << apartmentPrice << " lv." << std::endl;
    std::cout << "Studio: " << std::fixed << std::setprecision(2) << studioPrice << " lv." << std::endl;

    return 0;
}
