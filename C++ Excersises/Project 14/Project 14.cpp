#include <iostream>
#include <string>
#include <sstream>
#include <vector>
using namespace std;

class sentence
{
	string input;
	int count;
	vector<string> firstInput;
	string secondInput[100];
public:
	sentence() {
		input = "";
		count = 0;
	}

	sentence(string in, int c) {
		in = input;
		c = count;
	}

	void getInfo()
	{
		//cin.ignore();
		getline(cin, input);
		istringstream inp(input);
		string a;
		while (inp >> a)
		{
			firstInput.push_back(a);
		}
		cin >> count;
	}

	void doJob()
	{
		//for first and second
		int c = 0;
		string l = firstInput.back();
		firstInput.pop_back();
		secondInput[c] = firstInput.back();
		c++;
		firstInput.pop_back();
		secondInput[c] = l;
		c++;
		//for the rest
		for (size_t i = 0; i < firstInput.size(); i++)
		{
			if (firstInput.size() != 0)
			{
				secondInput[i + count] = firstInput[i];
			}
			else
			{
				break;
			}
		}
		if (count == 2) {
			for (string i : secondInput)
			{
				if (i == "")
				{
					break;
				}
				else
				{
					cout << i << endl;
				}
			}
		}
		else
		{
			for (string i : secondInput)
			{
				if (i == "")
				{
					break;
				}
				else
				{
					cout << i << endl;
				}
			}
		}
	}
};

int main()
{
	sentence s;
	s.getInfo();
	s.doJob();
}