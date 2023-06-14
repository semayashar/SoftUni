#include <iostream>
#include <string>
#include <iomanip>

int main() {
    int N1, N2;
    char oper;
    std::cin >> N1 >> N2 >> oper;

    double result;
    std::string resultType;

    switch (oper) {
    case '+':
        result = N1 + N2;
        resultType = (result % 2 == 0) ? "even" : "odd";
        std::cout << N1 << " + " << N2 << " = " << result << " - " << resultType << std::endl;
        break;
    case '-':
        result = N1 - N2;
        resultType = (result % 2 == 0) ? "even" : "odd";
        std::cout << N1 << " - " << N2 << " = " << result << " - " << resultType << std::endl;
        break;
    case '*':
        result = N1 * N2;
        resultType = (result % 2 == 0) ? "even" : "odd";
        std::cout << N1 << " * " << N2 << " = " << result << " - " << resultType << std::endl;
        break;
    case '/':
        if (N2 != 0) {
            result = static_cast<double>(N1) / N2;
            std::cout << N1 << " / " << N2 << " = " << std::fixed << std::setprecision(2) << result << std::endl;
        }
        else {
            std::cout << "Cannot divide " << N1 << " by zero" << std::endl;
        }
        break;
    case '%':
        if (N2 != 0) {
            result = N1 % N2;
            std::cout << N1 << " % " << N2 << " = " << result << std::endl;
        }
        else {
            std::cout << "Cannot divide " << N1 << " by zero" << std::endl;
        }
        break;
    }

    return 0;
}
