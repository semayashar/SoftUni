#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    int chicken_menus, fish_menus, vegetarian_menus;
    double chicken_menu_price = 10.35, fish_menu_price = 12.40, vegetarian_menu_price = 8.15;
    double dessert_percent = 0.2, delivery_price = 2.50;

    cin >> chicken_menus >> fish_menus >> vegetarian_menus;

    double total_price = (chicken_menus * chicken_menu_price) + (fish_menus * fish_menu_price) + (vegetarian_menus * vegetarian_menu_price);
    double dessert_price = total_price * dessert_percent;
    double final_price = total_price + dessert_price + delivery_price;

    cout << fixed << setprecision(2) << final_price << endl;

    return 0;
}
