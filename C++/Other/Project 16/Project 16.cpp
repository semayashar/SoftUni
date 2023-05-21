#include <iostream>
#include <string>
#include <stack>
#include <sstream>
#include <climits>
using namespace std;


int main()
{
	int N, S, X;
	stack<int> stack1;
	cin >> N >> S >> X;

	if (N == 0 || N == S)
	{
		cout << "0" << endl;
		return 0;
	}

	for (int i = 0; i < N; i++)
	{
		int cur;
		cin >> cur;
		stack1.push(cur);
	}
	stack<int> sec;

	for (int i = 0; i < stack1.size(); stack1.pop())
	{
		int cur = stack1.top();
		sec.push(cur);
	}


	for (int i = 0; i < S; i++)
	{
		sec.pop();
	}

	int min = INT_MAX;

	for (int i = 0; i < sec.size(); i++)
	{
		int cur = sec.top();
		if (cur < min)
		{
			min = cur;
		}

		if (cur == X)
		{
			cout << "true" << endl;
			return 0;
		}

		sec.pop();
	}
	cout << min << endl;
	return 0;
	int commands;
	cin >> commands;
	stack<int> numbers;
	for (int i = 0; i < commands; i++)
	{
		int com, number;
		cin >> com;
		switch (com)
		{
		case 1: {
			cin >> number;
			numbers.push(number); }
			  break;
		case 2: {
			if (!numbers.empty())
			{
				numbers.pop();
			}
		}
			  break;
		case 3: {
			int max = INT_MIN;
			stack <int>sec(numbers);
			for (int i = 0; i < sec.size(); sec.pop())
			{
				if (sec.top() > max)
				{
					max = sec.top();
				}
			}
			cout << max << endl;
		}
			  break;
		case 4: {
			int min = INT_MAX;
			stack <int>sec(numbers);
			for (int i = 0; i < sec.size(); sec.pop())
			{
				if (sec.top() < min)
				{
					min = sec.top();
				}
			}
			cout << min << endl;
		}
			  break;
		default:
			break;
		}
	}
	for (int i = 1; i < numbers.size(); numbers.pop())
	{
		cout << numbers.top() << ", ";
	}
	cout << numbers.top();
	numbers.pop();

}
