#include <iostream>
#include <vector>
#include <string>
#include <unordered_map>
#include <list>
#include <sstream>
using namespace std;

bool doWeHave(unordered_map<string, float> m, string n)
{
	for (auto pair1 : m) {

		if (pair1.first == n)
		{
			return true;
		}
	}
	return false;
}

int main()
{
	int count;
	cin >> count;
	unordered_map <string, float> towns;


	for (int i = 0; i < count;)
	{
		string name; cin.ignore(); getline(cin, name);
		//istringstream input(name); string x;
		char lst = name[name.length() - 1];
		while (isspace(lst))
		{
			name.pop_back();
			lst = name[name.length() - 1];
		}
		float pricePerProduct; cin >> pricePerProduct;
		int quantity; cin >> quantity;
		if (i == 0)
		{
			int p = pricePerProduct * quantity;
			towns.insert(pair<string, float>(name, p));
			i++;
		}
		else
		{
			if (doWeHave(towns, name) == false)
			{
				int p = pricePerProduct * quantity;
				towns.insert(pair<string, float>(name, p));
				i++;
			}
			else
			{
				std::unordered_map<string, float>::iterator itr;
				itr = towns.find(name);
				float p = itr->second;
				float fp = (pricePerProduct * quantity) + p;
				itr->second = fp;
			}
		}
	}

	for (auto pair : towns) {
		cout << pair.first << " " << pair.second << endl;
	}
}