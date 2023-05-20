#include <iostream>
#include <unordered_map>
#include <string>
#include <utility>
using namespace std;


int main()
{
	unordered_map<string, int> pepi;
	unordered_map<string, int> mimi;
	unordered_map<string, int>::iterator itP = pepi.begin();
	unordered_map<string, int>::iterator itM = mimi.begin();

	int n, times;
	cin >> n;
	string person, who;
	for (int i = 0; i < n; i++)
	{
		cin >> who;
		if (who == "Pepi")
		{
			cin >> person;
			cin >> times;
			pepi.insert(pair<string, int>(person, times));
		}
		if (who == "Mimi")
		{
			cin >> person;
			cin >> times;
			mimi.insert(pair<string, int>(person, times));
		}

	}
	int t;
	cin >> t;

	itP = pepi.begin();
	itM = mimi.begin();
	for (int i = 0; i < t; i++)
	{
		while (itP != pepi.end() && itP != pepi.end())
		{
			if (itP != pepi.end())
			{
				if (itP->second > 0)
				{
					cout << "Pepi processing " << itP->first << endl;
					itP->second--;
				}
				else if (itP->second == 0)
				{
					itP++;
					cout << "Pepi processing " << itP->first << endl;
					itP->second--;
				}
			}

			if (itM != mimi.end())
			{
				if (itM->second > 0)
				{
					cout << "Mimi processing " << itM->first << endl;
					itM->second--;
				}
				else if (itM->second == 0 && itM == mimi.end())
				{
					cout << "Mimi Idle" << endl;
				}
				else
				{
					itM++;
					cout << "Mimi processing " << itM->first << endl;
					itM->second--;
				}

			}
			break;
		}
	}
}
