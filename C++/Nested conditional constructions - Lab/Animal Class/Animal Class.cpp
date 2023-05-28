#include <iostream>
#include <string>

int main() {
    std::string animalName;

    std::cout << "Enter the name of the animal: ";
    std::cin >> animalName;

    if (animalName == "dog")
        std::cout << "mammal\n";
    else if (animalName == "crocodile" || animalName == "tortoise" || animalName == "snake")
        std::cout << "reptile\n";
    else
        std::cout << "unknown\n";

    return 0;
}
