#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    int training_fee;
    double basketball_shoes_price, basketball_kit_price, basketball_ball_price, basketball_accessories_price;

    cin >> training_fee;

    basketball_shoes_price = training_fee - (training_fee * 0.4);
    basketball_kit_price = basketball_shoes_price - (basketball_shoes_price * 0.2);
    basketball_ball_price = basketball_kit_price / 4;
    basketball_accessories_price = basketball_ball_price / 5;

    double total_price = training_fee + basketball_shoes_price + basketball_kit_price + basketball_ball_price + basketball_accessories_price;

    cout << fixed << setprecision(2) << total_price << endl;

    return 0;
}
