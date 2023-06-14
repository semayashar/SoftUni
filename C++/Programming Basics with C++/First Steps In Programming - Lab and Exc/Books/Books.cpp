#include <iostream>

int main() {
    int totalPages, pagesPerHour, daysToRead;
    int totalHours, hoursPerDay;

    std::cout << "Брой страници в текущата книга: ";
    std::cin >> totalPages;

    std::cout << "Страници, които прочита за 1 час: ";
    std::cin >> pagesPerHour;

    std::cout << "Брой дни, за които трябва да прочете книгата: ";
    std::cin >> daysToRead;

    totalHours = totalPages / pagesPerHour;
    hoursPerDay = totalHours / daysToRead;

    std::cout << "Часове на ден: " << hoursPerDay << std::endl;

    return 0;
}
