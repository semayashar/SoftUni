#include <iostream>
#include <string>
#include <iomanip>

int main() {
    double budget;
    std::string season;
    std::string destination;
    double expenses = 0;

    // Read input from the user
    std::cout << "Budget: ";
    std::cin >> budget;
    std::cout << "Season: ";
    std::cin >> season;

    // Determine the destination based on the budget
    if (budget <= 100) {
        destination = "Bulgaria";
        if (season == "summer") {
            expenses = 0.3 * budget;
        }
        else if (season == "winter") {
            expenses = 0.7 * budget;
        }
    }
    else if (budget <= 1000) {
        destination = "Balkans";
        if (season == "summer") {
            expenses = 0.4 * budget;
        }
        else if (season == "winter") {
            expenses = 0.8 * budget;
        }
    }
    else {
        destination = "Europe";
        expenses = 0.9 * budget;
    }

    // Determine the type of vacation (Camp or Hotel)
    std::string vacationType;
    if (destination == "Europe") {
        vacationType = "Hotel";
    }
    else {
        vacationType = "Camp";
    }

    // Print the result
    std::cout << "Somewhere in " << destination << std::endl;
    std::cout << vacationType << " - " << std::fixed << std::setprecision(2) << expenses << std::endl;

    return 0;
}
