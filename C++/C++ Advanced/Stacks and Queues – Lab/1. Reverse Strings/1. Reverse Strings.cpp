#include <iostream>
#include <stack>
#include <sstream>
#include <string>
using namespace std;

int main()
{
    string input;
    getline(std::cin, input);

    istringstream iss(input);
    string word;
    stack<std::string> wordStack;

    // Extract words and push them onto the stack
    while (iss >> word) {
        wordStack.push(word);
    }

    // Pop words from the stack and print them
    while (!wordStack.empty()) {
        cout << wordStack.top() << endl;
        wordStack.pop();
    }

    return 0;
}
