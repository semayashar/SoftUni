#include <iostream>
#include <sstream>
#include <string>
#include <list>
#include <vector>

using namespace std;



/*

void function(istringstream& i, list<string>& s) {
	string a;
	while (i >> a)
	{
		s.push_front(a);
	}
}
int charToInt(string line, string letterArray)
{
	string number;
	for (int i = 0; i < line.length(); i++)
	{
		for (int j = 0; j < 10; j++)
		{
			if (line[i] == letterArray[j])
			{
				number+=to_string(j);
				break;
			}

		}
	}
	int numberINT;
	stringstream geek(number);
	geek >> numberINT;
	return numberINT;
}
string intToChar(int numberINT, string letterArray)
{
	string numberStr = to_string(numberINT);

	string word = "";
	for (int j = 0; j < numberStr.length(); j++)
	{
		for (int i = 0; i < 10; i++)
		{
			string jS = to_string(i);
			if (numberStr[j] == jS[0])
			{
				word += letterArray[i];
				break;
			}
		}
	}
	return word;
}*/
void f(string task1, string task2, string task3) {
	cin >> task1; cin >> task2; cin >> task3;
	cout << "Name:" << "		" << task1 << "		" << task2 << "		" << task3 << "		" << "Total:" << endl;
}
vector<string> funcionForRazdelyaneNaChislaOtBukviVuvVector(string input) {
	vector<string> vec1;
	int i = 0;
	int z = 0;
	for (int y = 0; y < input.length();)
	{
		string a;
		if (input[y] >= 48 && input[y] <= 58)
		{
			z = y;
			while (input[z] >= 48 && input[z] <= 58)
			{
				a += input[z];
				z++;
				y++;
			}
			vec1.push_back(a);
		}
		else
		{
			i++;
			string a;
			a += input[y];
			vec1.push_back(a);
			i++;
			y++;
		}

	}

	for (int i = 0; i < vec1.size(); i++)
	{
		if (vec1[i] >= "0" && vec1[i] <= "9")
		{
			int number = stoi(vec1[i]);

			vector<string>::iterator it = vec1.begin() + i;
			vec1.erase(it);
			for (int j = 0; j < number - 1; j++)
			{
				string letter = vec1[i];
				it = vec1.insert(vec1.begin() + i, letter);

			}
		}
	}
	return vec1;
}
int findIndex(vector<string>& data, string& query) {
	int queryColum = 0;
	for (string colName : data) {
		if (colName == query)
		{
			return queryColum;
		}
		queryColum++;
	}
	return -1;
}
int main()
{
	/*string now = "";
	string inputStr;
	while (now != "end")
	{
		cin >> now;
		if (now == "end")
		{
			break;
		}
		else
		{
			inputStr += now + ' ';
		}
	}
	istringstream input(inputStr);
	list<string> output;
	function(input, output);
	for (string i : output)
	{
		std::cout << i << ' ';
	}*/

	/*string alphabet;
	cin >> alphabet;


	string firstLine;
	cin >> firstLine;


	string secondLine;
	cin >> secondLine;

	int firstNumber = charToInt(firstLine, alphabet);
	int secondNumber = charToInt(secondLine, alphabet);
	int resultINT = firstNumber + secondNumber;
	cout << intToChar(resultINT, alphabet)<<endl;*/

	/*vector<char> alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
	string input;
	cin >> input;
	for (size_t i = 0; i < input.length(); i++)
	{
		for (size_t j = 0; j < alphabet.size(); j++)
		{
			if (input[i] == alphabet[j])
			{
				vector<char>::iterator it = alphabet.begin() + j;
				alphabet.erase(it);
				break;
			}
		}
	}
	for (size_t i = 0; i < alphabet.size(); i++)
	{
		cout << alphabet[i] ;
	}*/

	/*string input;
	cin >> input;

	vector<string> vec1(funcionForRazdelyaneNaChislaOtBukviVuvVector(input));

	for (int i = 0; i < vec1.size(); i++)
	{
		cout << vec1[i];
	}*/

	vector<string> columns;
	vector<vector<string>> data;
	string query;

	string buf;
	getline(cin, buf);

	istringstream columnstream(buf);
	string colBuf;
	while (columnstream >> colBuf)
	{
		columns.push_back(colBuf);
	}

	while (true)
	{
		getline(cin, buf);
		if (buf == "end")
		{
			break;
		}
		istringstream inputStream(buf);
		string itemBuf;
		vector<string> curLine;
		while (inputStream >> itemBuf)
		{
			curLine.push_back(itemBuf);
		}
		data.push_back(curLine);
	}
	cin >> query;

	int queryColumn = findIndex(columns, query);

	vector<string> queryData;
	vector<string> caoutData;
	for (vector<string>& row : data)
	{

	}
}