#include <iostream>
#include <map>
#include <vector>
using namespace std;

bool havewe(string name, vector<string> towns, int& count) {
	for (int i = 0; i < towns.size(); i++)
	{
		if (towns[i] == name)
		{
			return true;
		}

	}
	count++;
	return false;
}

int main()
{
	int count = 0;
	string name;
	int min = INT_MAX;
	int max = INT_MIN;
	vector<string> towns;
	cin >> count;
	map<string, map<int, int>> weather;
	for (auto i = weather.begin(); i != weather.end(); i++)
	{
		cin >> name;
		if (i == weather.begin())
		{
			towns.push_back(name);
			cin >> min;
			cin >> max;
			weather.insert(make_pair(name, map<int, int>()));
			weather[name].insert(make_pair(min, max));
			count++;
		}
		else
		{
			if (havewe(name, towns, count) == false)
			{
				towns.push_back(name);
				cin >> min;
				cin >> max;
				weather.insert(make_pair(name, map<int, int>()));
				weather[name].insert(make_pair(min, max));
			}
			else
			{
				map<string, map<int, int>>::iterator iter = weather.find(name);
			}

		}


	}
}