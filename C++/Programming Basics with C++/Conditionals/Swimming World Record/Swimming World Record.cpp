#include <iostream>
#include <cmath>
#include <iomanip>

int main() {
    double recordSeconds, distanceMeters, secondsPerMeter;

    std::cin >> recordSeconds >> distanceMeters >> secondsPerMeter;

    double resistanceTime = std::floor(distanceMeters / 15) * 12.5;
    double ivanTime = distanceMeters * secondsPerMeter + resistanceTime;

    if (ivanTime < recordSeconds) {
        std::cout << "Yes, he succeeded! The new world record is " << std::fixed << std::setprecision(2) << ivanTime << " seconds." << std::endl;
    }
    else {
        double difference = ivanTime - recordSeconds;
        std::cout << "No, he failed! He was " << std::fixed << std::setprecision(2) << difference << " seconds slower." << std::endl;
    }

    return 0;
}
