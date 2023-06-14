#include <iostream>

int main() {
    int countForDogs, countForCats;

    std::cout << "Enter count of dog food packages: ";
    std::cin >> countForDogs;
    std::cout << "Enter count of cat food packages: ";
    std::cin >> countForCats;

    double priceForDogs = 2.50 * countForDogs;
    double priceForCats = 4.0 * countForCats;
    double sum = priceForDogs + priceForCats;

    std::cout << "The sum is $" << sum;

    return 0;
}
