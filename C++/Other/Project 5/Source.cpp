#include <iostream>
#include <vector>
#include <list>
#include <sstream>
#include <string>
using namespace std;
//
//bool isNotVovel(string input, int i)
//{
//	string vovels = "aeiou";
//	for (size_t j = 0; j < 6; j++)
//	{
//		if (input[i] == vovels[j])
//		{
//			return false;
//			break;
//		}
//	}
//	return true;
//}
//
//vector<int> sum(vector<int> &vec)
//{
//	int size = vec.size();
//	vector<int>::iterator it;
//	it = vec.begin() + vec.size() - 1;
//	int last = vec[size-1];
//	int bfrLast = vec[size-2];
//	vec.erase(it);
//	it = vec.begin() + vec.size() - 1;
//	vec.erase(it); 
//	vec.push_back(last + bfrLast);
//	return vec;
//}
//vector<int> substract(vector<int>& vec)
//{
//	int size = vec.size();
//	vector<int>::iterator it;
//	it = vec.begin() + vec.size() - 1;
//	int last = vec[size - 1];
//	int bfrLast = vec[size - 2];
//	vec.erase(it);
//	it = vec.begin() + vec.size() - 1;
//	vec.erase(it);
//	vec.push_back(last - bfrLast);
//	return vec;
//}
//vector<int> concat(vector<int>& vec)
//{
//	int size = vec.size();
//	vector<int>::iterator it;
//	it = vec.begin() + vec.size() - 1;
//	int last = vec[size - 1];
//	int bfrLast = vec[size - 2];
//	vec.erase(it);
//	it = vec.begin() + vec.size() - 1;
//	vec.erase(it);
//
//	string number = to_string(bfrLast) + to_string(last);
//	int numberINT = stoi(number);
//
//	vec.push_back(numberINT);
//	return vec;
//}
//vector<int> discard(vector<int>& vec)
//{
//	vector<int>::iterator it;
//	it = vec.begin() + vec.size() - 1;
//	vec.erase(it);
//	return vec;
//}
int main()
{
	/*
	size_t count; cin >> count; string ar;
	vector<int> vec1;
	for (size_t i = 0; i < count; i++)
	{
		cin >> ar;
		istringstream stream(ar);
		string n;
		while (stream >> n)
		{
			int z = stoi(n);
			vec1.push_back(z);
			break;
		}
	}

	//average:
	int sum = 0;
	int size = vec1.size();
	for (size_t i = 0; i < vec1.size(); i++)
	{
		sum += vec1[i];
	}
	int average = sum / size;
	vector<int> chetni;
	vector<int> neChetni;
	for (size_t i = 0; i < size; i++)
	{
		if (vec1[i] <= average)
		{
			if (i % 2 == 0)
			{
				chetni.push_back(vec1[i]);
			}
			else
			{
				neChetni.push_back(vec1[i]);
			}
		}
		else
		{
			break;
		}
	}

	int sumOfEven = 0;
	int sumOfOdd = 0;
	for (size_t i = 0; i < chetni.size(); i++)
	{
		sumOfEven += chetni[i];
	}
	for (size_t i = 0; i < neChetni.size(); i++)
	{
		sumOfOdd += neChetni[i];
	}
	int result = sumOfEven * sumOfOdd;
	cout << result;*/
	/*string input;
	getline(cin, input);

	string lastChar;
	string::iterator it;
	for (size_t i = 0; i < input.length(); i++)
	{
		if (isNotVovel(input, i))
		{
			while (input[i] == input[i + 1])
			{
				it = input.begin() + i + 1;
				input.erase(it);
			}
		}
	}
	cout << input;*/
	// vector<int> vec1;
	//while (true)
	//{
	//	string input;
	//	cin >> input;
	//	if (input == "end")
	//	{
	//		break;
	//	}
	//	
	//	istringstream stream(input);
	//	string cur;
	//	while (stream>>cur)
	//	{
	//		if (cur == "sum")
	//		{
	//			vec1 = sum(vec1);
	//		}
	//		else if (cur == "subtract")
	//		{
	//			vec1 = substract(vec1);
	//		}
	//		else if (cur == "concat")
	//		{
	//			vec1 = concat(vec1);
	//		}
	//		else if (cur == "discard")
	//		{
	//			vec1 = discard(vec1);
	//		}
	//		else
	//		{
	//			vec1.push_back(stoi(cur));
	//		}
	//	}
	//}
	//for (size_t i = 0; i < vec1.size(); i++)
	//{
	//	cout << vec1[i]<<endl;
	//}
	double a, b;
	a = 3.14;
	b = 1.15;
	cout << a + b;

}