#include <iostream>
#include <string>
using namespace std;

int main() {
    string day;

    // Read a day of the week in English
    cout << "Enter a day of the week: ";
    cin >> day;

    // Check if it's a working day or weekend day
    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") {
        cout << "Working day" << endl;
    }
    else if (day == "Saturday" || day == "Sunday") {
        cout << "Weekend" << endl;
    }
    else {
        cout << "Error" << endl;
    }

    return 0;
}
