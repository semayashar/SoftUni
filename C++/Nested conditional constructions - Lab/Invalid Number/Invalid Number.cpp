#include <iostream>

int main() {
    int number;
    std::cin >> number;

    if (!(number >= 100 && number <= 200) && number != 0) {
        std::cout << "invalid";
    }

    return 0;
}
