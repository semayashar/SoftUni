#include <iostream>
#include <string>

int main() {
    int degrees;
    std::string timeOfDay;
    std::string outfit;
    std::string shoes;

    // Read input from the user
    std::cout << "Degrees: ";
    std::cin >> degrees;
    std::cout << "Time of day (Morning/Afternoon/Evening): ";
    std::cin >> timeOfDay;

    // Determine the outfit and shoes based on temperature and time of day
    if (degrees >= 10 && degrees <= 18) {
        if (timeOfDay == "Morning") {
            outfit = "Sweatshirt";
            shoes = "Sneakers";
        }
        else if (timeOfDay == "Afternoon" || timeOfDay == "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    }
    else if (degrees > 18 && degrees <= 24) {
        if (timeOfDay == "Morning") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else if (timeOfDay == "Afternoon") {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        else if (timeOfDay == "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    }
    else if (degrees >= 25) {
        if (timeOfDay == "Morning" || timeOfDay == "Afternoon") {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        else if (timeOfDay == "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    }

    // Print the result
    std::cout << "It's " << degrees << " degrees, get your " << outfit << " and " << shoes << "." << std::endl;

    return 0;
}
