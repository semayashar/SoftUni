#include <iostream>
#include <queue>
#include <string>

std::string simulateHotPotato(const std::queue<std::string>& circle, int n) {
    std::queue<std::string> gameCircle = circle;

    while (gameCircle.size() > 1) {
        for (int i = 0; i < n - 1; i++) {
            std::string currentKid = gameCircle.front();
            gameCircle.pop();
            gameCircle.push(currentKid);
        }
        std::cout << "Removed " << gameCircle.front() << std::endl;
        gameCircle.pop();
    }

    return gameCircle.front();
}

int main() {
    std::queue<std::string> circle;
    std::string name;

    std::cout << "Enter children's names (separated by spaces): ";
    while (std::cin >> name && name != "End") {
        circle.push(name);
    }

    int n;
    std::cout << "Enter the counting number (n): ";
    std::cin >> n;

    std::string lastKid = simulateHotPotato(circle, n);
    std::cout << "Last is " << lastKid << std::endl;

    return 0;
}
