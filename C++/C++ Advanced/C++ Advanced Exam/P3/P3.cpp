#include <iostream>
#include <queue>
#include <string>

struct Customer {
    std::string name;
    int turnsLeft;
};

void processCustomers(std::queue<Customer>& pepiQueue, std::queue<Customer>& mimiQueue) {
    if (!pepiQueue.empty()) {
        Customer& pepiCustomer = pepiQueue.front();
        std::cout << "Pepi processing " << pepiCustomer.name << std::endl;
        pepiCustomer.turnsLeft--;
        if (pepiCustomer.turnsLeft == 0) {
            pepiQueue.pop();
        }
    }
    else {
        std::cout << "Pepi Idle" << std::endl;
    }

    if (!mimiQueue.empty()) {
        Customer& mimiCustomer = mimiQueue.front();
        std::cout << "Mimi processing " << mimiCustomer.name << std::endl;
        mimiCustomer.turnsLeft--;
        if (mimiCustomer.turnsLeft == 0) {
            mimiQueue.pop();
        }
    }
    else {
        std::cout << "Mimi Idle" << std::endl;
    }
}

int main() {
    int numCustomers;
    std::cin >> numCustomers;

    std::queue<Customer> pepiQueue;
    std::queue<Customer> mimiQueue;

    for (int i = 0; i < numCustomers; i++) {
        std::string name;
        std::string customerName;
        int turns;
        std::cin >> name >> customerName >> turns;
        Customer customer = { customerName, turns };

        if (name == "Pepi") {
            pepiQueue.push(customer);
        }
        else if (name == "Mimi") {
            mimiQueue.push(customer);
        }
    }

    int numTurns;
    std::cin >> numTurns;

    for (int i = 0; i < numTurns; i++) {
        processCustomers(pepiQueue, mimiQueue);
    }

    return 0;
}
