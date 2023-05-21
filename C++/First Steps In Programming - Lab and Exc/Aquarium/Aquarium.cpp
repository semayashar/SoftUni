#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    int length, width, height;
    double percent_full;

    cin >> length >> width >> height >> percent_full;

    double volume_cm = length * width * height;
    double volume_liters = volume_cm * 0.001;
    double percent = percent_full / 100;

    double needed_liters = volume_liters * (1 - percent);

    cout << fixed << setprecision(5) << needed_liters << endl;

    return 0;
}
