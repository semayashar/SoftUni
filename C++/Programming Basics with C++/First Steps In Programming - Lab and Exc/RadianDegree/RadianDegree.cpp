#include <iostream>
#include <cmath> // За използване на round()

int main() {
    double radian, degree;
    const double pi = 3.14159;

    std::cout << "Въведете ъгъл в радиани: ";
    std::cin >> radian;

    degree = radian * 180 / pi;
    degree = round(degree);

    std::cout << "Ъгъл в градуси: " << degree << std::endl;

    return 0;
}
