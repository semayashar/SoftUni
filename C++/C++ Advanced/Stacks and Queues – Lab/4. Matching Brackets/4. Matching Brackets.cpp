#include <iostream>
#include <stack>
#include <string>

void extractSubExpressions(const std::string& expression) {
    std::stack<int> bracketIndices;

    for (int i = 0; i < expression.length(); i++) {
        if (expression[i] == '(') {
            bracketIndices.push(i);
        }
        else if (expression[i] == ')') {
            if (!bracketIndices.empty()) {
                int start = bracketIndices.top();
                bracketIndices.pop();
                int end = i;
                std::cout << expression.substr(start + 1, end - start - 1) << std::endl;
            }
        }
    }
}

int main() {
    std::string expression;
    std::cout << "Enter arithmetic expression: ";
    std::getline(std::cin, expression);

    extractSubExpressions(expression);

    return 0;
}
