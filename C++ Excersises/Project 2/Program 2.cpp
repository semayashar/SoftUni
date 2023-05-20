#include <iostream>
#include <sstream>
#include <string>
#include <list>

using namespace std;

void function(istringstream& i, list<string>& s) {
    string a;
    while (i >> a)
    {
        s.push_front(a);
    }
}

int main()
{
    string now;
    string inputStr;
    getline(cin, now); // Read the input line
    while (now != "end")
    {
        inputStr += now + ' '; // Concatenate input strings
        getline(cin, now); // Read the next input line
    }

    istringstream input(inputStr);
    list<string> output;
    function(input, output);
    for (string i : output)
        cout << i << ' ';

    return 0;
}
