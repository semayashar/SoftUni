#include <iostream>
#include <string>

int main() {
    int examHour, examMinute, arrivalHour, arrivalMinute;
    std::cin >> examHour >> examMinute >> arrivalHour >> arrivalMinute;

    int examTime = examHour * 60 + examMinute;
    int arrivalTime = arrivalHour * 60 + arrivalMinute;
    int difference = arrivalTime - examTime;

    std::string status;

    if (difference > 0) {
        status = "Late";
    }
    else if (difference >= -30) {
        status = "On time";
    }
    else {
        status = "Early";
    }

    int hours = abs(difference) / 60;
    int minutes = abs(difference) % 60;

    if (status == "Late" && hours == 0) {
        std::cout << status << "\n" << minutes << " minutes after the start\n";
    }
    else if (status == "Late" && hours > 0) {
        std::cout << status << "\n" << hours << ":" << std::setfill('0') << std::setw(2) << minutes << " hours after the start\n";
    }
    else if (status == "On time" || (status == "Early" && hours >= 1)) {
        std::cout << status << "\n";
    }
    else {
        std::cout << status << "\n" << minutes << " minutes before the start\n";
    }

    return 0;
}
