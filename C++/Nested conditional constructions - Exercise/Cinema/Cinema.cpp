#include <iostream>
#include <iomanip>
#include <string>

int main() {
    std::string projectionType;
    int rows, columns;
    double ticketPrice = 0.0;
    double income = 0.0;

    // Read input from the user
    std::cout << "Projection type: ";
    std::cin >> projectionType;
    std::cout << "Number of rows: ";
    std::cin >> rows;
    std::cout << "Number of columns: ";
    std::cin >> columns;

    // Calculate ticket price based on projection type
    if (projectionType == "Premiere") {
        ticketPrice = 12.00;
    }
    else if (projectionType == "Normal") {
        ticketPrice = 7.50;
    }
    else if (projectionType == "Discount") {
        ticketPrice = 5.00;
    }
    else {
        std::cout << "Invalid projection type." << std::endl;
        return 0;
    }

    // Calculate total income
    income = rows * columns * ticketPrice;

    // Print the result
    std::cout << std::fixed << std::setprecision(2);
    std::cout << "Total income: " << income << " leva" << std::endl;

    return 0;
}
