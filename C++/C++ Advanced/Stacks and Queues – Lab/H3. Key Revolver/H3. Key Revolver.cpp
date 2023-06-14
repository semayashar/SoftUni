#include <iostream>
#include <vector>

int main() {
    int bulletPrice, barrelSize;
    std::cin >> bulletPrice >> barrelSize;

    std::vector<int> bullets;
    int bullet;
    while (std::cin >> bullet && bullet != -1) {
        bullets.push_back(bullet);
    }

    std::vector<int> locks;
    int lock;
    while (std::cin >> lock && lock != -1) {
        locks.push_back(lock);
    }

    int intelligenceValue;
    std::cin >> intelligenceValue;

    int bulletsLeft = barrelSize;
    int moneyEarned = 0;

    while (!locks.empty() && !bullets.empty()) {
        int currentBullet = bullets.back();
        bullets.pop_back();
        --bulletsLeft;

        int currentLock = locks.front();
        locks.erase(locks.begin());

        if (currentBullet <= currentLock) {
            std::cout << "Bang!" << std::endl;
            moneyEarned += bulletPrice;
        }
        else {
            std::cout << "Ping!" << std::endl;
        }

        if (bulletsLeft == 0 && !bullets.empty()) {
            std::cout << "Reloading!" << std::endl;
            bulletsLeft = barrelSize;
        }
    }

    if (locks.empty()) {
        int totalEarned = intelligenceValue - moneyEarned;
        std::cout << bulletsLeft << " bullets left. Earned $" << totalEarned << std::endl;
    }
    else {
        std::cout << "Couldn't get through. Locks left: " << locks.size() << std::endl;
    }

    return 0;
}
