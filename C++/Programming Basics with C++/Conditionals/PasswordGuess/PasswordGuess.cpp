#include <iostream>
#include <string>

int main() {
    std::string password;
    std::cout << "Enter the password: ";
    std::cin >> password;

    if (password == "s3cr3t!P@ssw0rd") {
        std::cout << "Welcome" << std::endl;
    }
    else {
        std::cout << "Wrong password!" << std::endl;
    }

    return 0;
}
