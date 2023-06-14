#include <iostream>
#include <queue>
#include <string>

int main() {
    std::queue<std::string> customerQueue;

    while (true) {
        std::string command;
        std::cin >> command;

        if (command == "End") {
            int remainingCount = customerQueue.size();
            std::cout << remainingCount << " people remaining." << std::endl;
            break;
        }
        else if (command == "Paid") {
            while (!customerQueue.empty()) {
                std::cout << customerQueue.front() << " ";
                customerQueue.pop();
            }
            std::cout << std::endl;
        }
        else {
            std::string name;
            std::cin >> name;
            customerQueue.push(name);
        }
    }

    return 0;
}
