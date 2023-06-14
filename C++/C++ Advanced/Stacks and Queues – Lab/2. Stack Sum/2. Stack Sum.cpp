#include <iostream>
#include <stack>
#include <sstream>
#include <string>

int main() {
    std::stack<int> numberStack;

    // Read the initial input of integers
    std::string input;
    std::getline(std::cin, input);
    std::istringstream iss(input);
    int num;
    while (iss >> num) {
        numberStack.push(num);
    }

    // Process commands until "end" is received
    while (true) {
        std::string command;
        std::getline(std::cin, command);

        if (command == "end")
            break;

        if (command == "add") {
            int num1, num2;
            std::cin >> num1 >> num2;
            numberStack.push(num1);
            numberStack.push(num2);
        }
        else if (command == "remove") {
            int count;
            std::cin >> count;
            while (count > 0 && !numberStack.empty()) {
                numberStack.pop();
                count--;
            }
        }
    }

    // Calculate the sum of remaining elements
    int sum = 0;
    while (!numberStack.empty()) {
        sum += numberStack.top();
        numberStack.pop();
    }

    std::cout << "Sum: " << sum << std::endl;

    return 0;
}
