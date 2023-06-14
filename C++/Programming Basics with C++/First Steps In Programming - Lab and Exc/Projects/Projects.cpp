#include <iostream>
#include <string>

int main() {
    std::string firstName;
    int projects;

    std::cout << "Enter name: ";
    std::getline(std::cin, firstName);
    std::cout << "Enter projects: ";
    std::cin >> projects;

    int hours = 3 * projects;

    std::cout << "\"The architect " << firstName << " will need " << hours << " hours to complete " << projects << " project/s." << std::endl;

    return 0;
}
