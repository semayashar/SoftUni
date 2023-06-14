#include <iostream>
#include <stack>
#include <sstream>
#include <string>

int evaluateExpression(const std::string& expression) {
    std::istringstream iss(expression);
    std::string token;
    std::stack<int> numberStack;
    int result = 0;
    int sign = 1;

    while (iss >> token) {
        if (token == "+") {
            sign = 1;
        }
        else if (token == "-") {
            sign = -1;
        }
        else {
            int number = std::stoi(token);
            result += sign * number;
        }
    }

    return result;
}

int main() {
    std::string expression;
    std::cout << "Enter expression: ";
    std::getline(std::cin, expression);

    int result = evaluateExpression(expression);
    std::cout << "Result: " << result << std::endl;

    return 0;
}
