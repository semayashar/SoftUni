#include <iostream>
#include <string>

int main() {
    double age;
    char gender;

    std::cout << "Enter the age: ";
    std::cin >> age;

    std::cout << "Enter the gender ('m' or 'f'): ";
    std::cin >> gender;

    if (gender == 'm') {
        if (age >= 16)
            std::cout << "Mr.\n";
        else
            std::cout << "Master\n";
    }
    else if (gender == 'f') {
        if (age >= 16)
            std::cout << "Ms.\n";
        else
            std::cout << "Miss\n";
    }

    return 0;
}
