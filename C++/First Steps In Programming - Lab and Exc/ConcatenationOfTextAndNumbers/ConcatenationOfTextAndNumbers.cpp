#include <iostream>
#include <string>

int main() {
    std::string firstName, lastName, town;
    int age;

    std::cout << "Enter first name: ";
    std::getline(std::cin, firstName);
    std::cout << "Enter last name: ";
    std::getline(std::cin, lastName);
    std::cout << "Enter age: ";
    std::cin >> age;
    std::cin.ignore(); // Ignore the newline character
    std::cout << "Enter town: ";
    std::getline(std::cin, town);

    std::cout << "You are " << firstName << " " << lastName << ", a " << age << "-years old person from " << town << "." << std::endl;

    return 0;
}
