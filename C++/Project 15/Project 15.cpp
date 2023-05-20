#include <iostream>
#include <utility>
#include <algorithm>
#include <set>
#include <sstream>
#include <map>
#include <vector>
#include <stack>
using namespace std;

bool word(stack<string> stack) {
	string word = stack.top();
	int counter = 0;
	word = stack.top();
	for (int i = 0; i < stack.size(); stack.pop())
	{
		if (stack.top() == word)
		{
			counter++;

		}
	}

	if (counter % 2 != 0)
	{
		return true;
	}
}

bool canWe(stack<string> stack, string word) {
	for (int i = 0; i < stack.size(); stack.pop())
	{
		if (word == stack.top())
		{
			return false;
		}
	}
	return true;
}

int main()
{
	/*map <double, int> answer;
	string inputS;
	getline(cin, inputS);
	istringstream input(inputS);
	double x;
	int counter = 0;
	vector <double> v;

	while (input>>x)
	{
		v.push_back(x);
	}

	for (int i = 0; i < v.size(); i++)
	{
		x = v[i];
		for (int y = i; y < v.size(); y++)
		{
			if (v[y] == x)
			{
				counter++;
			}
		}
		answer.insert(pair<double, int> {x, counter});
		counter = 0;
	}

	for (auto i = answer.begin(); i != answer.end(); i++)
	{
		cout << i->first << " -> "<< i->second << endl;
	}*/


	string inputS;
	getline(cin, inputS);
	string word1;
	stack <string> answer;
	stack <string> stack;


	for (int i = 0; i < inputS.length(); i++)
	{
		if (inputS[i] >= 'A' && inputS[i] <= 'Z')
		{
			inputS[i] = tolower(inputS[i]);
		}
	}

	istringstream input(inputS);

	while (input >> word1)
	{
		stack.push(word1);
	}

	while (stack.size() != 0)
	{

		for (int i = 0; i < stack.size(); i++)
		{
			word1 = stack.top();
			if (word(stack) == true && canWe(answer, word1) == true)
			{
				answer.push(word1);
			}
		}
	}

	for (int i = 0; i < answer.size() - 1; answer.pop())
	{
		cout << answer.top() << ", ";
	}
	cout << answer.top();
}