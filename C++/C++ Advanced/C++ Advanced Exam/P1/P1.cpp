#include <iostream>
#include <map>
#include <vector>
#include <algorithm>
#include <set>

struct TownData {
    int minTemp;
    int maxTemp;
};

int main() {
    int numTowns;
    std::cin >> numTowns;

    std::map<std::string, TownData> townMap;
    std::set<std::string> uniqueTowns; 
    for (int i = 0; i < numTowns;) {
        std::string town;
        std::cin >> town;

        int minTemp, maxTemp;
        std::cin >> minTemp >> maxTemp;

        if (townMap.find(town) != townMap.end()) {
            TownData& data = townMap[town];
            if (minTemp < data.minTemp) {
                data.minTemp = minTemp;
            }
            if (maxTemp > data.maxTemp) {
                data.maxTemp = maxTemp;
            }
        }
        else {
            townMap[town] = { minTemp, maxTemp };
            uniqueTowns.insert(town);
            ++i;
        }
    }

    std::vector<std::string> towns(uniqueTowns.begin(), uniqueTowns.end());
    std::sort(towns.begin(), towns.end());

    for (const std::string& town : towns) {
        const TownData& data = townMap[town];
        std::cout << town << " " << data.minTemp << " " << data.maxTemp << std::endl;
    }

    return 0;
}
