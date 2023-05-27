#include <iostream>
using namespace std;

int main() {
    int time1, time2, time3;
    cin >> time1 >> time2 >> time3;

    int totalSeconds = time1 + time2 + time3;
    int minutes = totalSeconds / 60;
    int seconds = totalSeconds % 60;

    if (seconds < 10) {
        cout << minutes << ":0" << seconds << endl;
    }
    else {
        cout << minutes << ":" << seconds << endl;
    }

    return 0;
}
