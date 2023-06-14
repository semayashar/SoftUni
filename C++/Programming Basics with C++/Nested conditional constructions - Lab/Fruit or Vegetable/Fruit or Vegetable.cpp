#include <iostream>
#include <string>

int main() {
    std::string product;
    std::cin >> product;

    if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon" || product == "grapes") {
        std::cout << "fruit";
    }
    else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot") {
        std::cout << "vegetable";
    }
    else {
        std::cout << "unknown";
    }

    return 0;
}
