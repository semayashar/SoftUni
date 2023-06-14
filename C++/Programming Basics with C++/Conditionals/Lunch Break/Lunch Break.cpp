#include <iostream>
#include <cmath>
#include <iomanip>

int main() {
    std::string seriesName;
    int episodeDuration, breakDuration;

    std::cin >> seriesName >> episodeDuration >> breakDuration;

    double lunchTime = breakDuration * 1.0 / 8;
    double restTime = breakDuration * 1.0 / 4;
    double remainingTime = breakDuration - lunchTime - restTime;

    if (remainingTime >= episodeDuration) {
        int freeTime = std::round(remainingTime - episodeDuration);
        std::cout << "You have enough time to watch " << seriesName << " and left with " << freeTime << " minutes free time." << std::endl;
    }
    else {
        int neededTime = std::round(episodeDuration - remainingTime);
        std::cout << "You don't have enough time to watch " << seriesName << ", you need " << neededTime << " more minutes." << std::endl;
    }

    return 0;
}
