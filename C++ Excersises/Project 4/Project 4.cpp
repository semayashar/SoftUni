#include <iostream>
#include <vector>
#include <string>
#include <sstream>
#include <cctype>

using namespace std;

bool findEquality(const vector<int>& a, const vector<int>& b)
{
    if (a.size() != b.size())
    {
        return false;
    }

    for (int i = 0; i < a.size(); i++)
    {
        if (a[i] != b[i])
        {
            return false;
        }
    }
    return true;
}

void getArray(vector<int>& a, istringstream& stream)
{
    int currentNumber;
    while (stream >> currentNumber)
    {
        a.push_back(currentNumber);
    }
}

int main()
{
    /*string str1, str2;
    getline(cin, str1);
    getline(cin, str2);

    vector <int> vec1;
    vector <int> vec2;
    istringstream stream1(str1);
    istringstream stream2(str2);
    getArray(vec1, stream1);
    getArray(vec2, stream2);

    cout << (findEquality(vec1, vec2) ? "equal" : "not equal") << endl;*/

    /*string str1;
    getline(cin, str1);
    istringstream stream1(str1);
    char c;
    int depth = 0;
    while (stream1 >> c)
    {
        switch (c)
        {
        case '(': depth++; break;
        case ')': depth--; break;
        default:
            break;
        }
    }
    cout << (depth == 0 ? "correct" : "incorrect") << endl;*/

    /*int flag = 1;
    string input;
    getline(cin, input);
    ostringstream output;
    int index = 0;
    while (index < input.length())
    {
        char c = input[index];
        index++;
        if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
        {
            //we detected letter
            if (flag)
            {
                c = toupper(c);
                if (c >= 'a' && c <= 'z')
                {
                    c = c - ('a' - 'A');
                }
                flag = 0;
            }
        }
        else
        {
            //we detected non-letter
            flag = 1;
        }
        output << c;
    }
    cout << output.str() << endl;*/

    /*string input;
    getline(cin, input);
    string find;
    getline(cin, find);
    string replace;
    getline(cin, replace);
    istringstream stream1(input);

    int foundIndex = input.find(find);
    while (foundIndex != string::npos)
    {
        input.replace(foundIndex, find.length(), replace);
        foundIndex += replace.length();
        foundIndex = input.find(find, foundIndex);
    }
    cout << input;*/

    /*string inp;
    getline(cin, inp);
    istringstream input(inp);
    string current;
    ostringstream streamLetters;
    int sum = 0;
    while (input >> current)
    {
        char c = current[0];
        if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
        {
            streamLetters << current << ' ';
        }
        else
        {
            int n = stoi(current);
            sum += n;
        }
    }
    cout << sum << endl;
    cout << streamLetters.str() << endl;*/

    /*string line;
    getline(cin, line);
    istringstream input(line);
    string current;
    unsigned max = 0;
    while (input >> current)
    {
        unsigned num = 0;
        int index;
        for (index = 0; index < current.length(); index++)
        {
            char c = current[index];
            if (c >= '0' && c <= '9')
            {
                num = num * 10 + (c - '0');
            }
        }
        if (num > max)
        {
            max = num;
        }
    }
    cout << max << endl;*/

    string line;
    getline(cin, line);

    istringstream input(line);
    string current;

    string minNoise = "";

    while (input >> current)
    {
        string currentNoise;

        for (int index = 0; index < current.length(); index++)
        {
            char c = current[index];
            if (!(c >= '0' && c <= '9'))
            {
                currentNoise += c;
            }
        }

        if (currentNoise.length() > minNoise.length())
        {
            minNoise = currentNoise;
        }
        else if (currentNoise.length() == minNoise.length() && currentNoise < minNoise)
        {
            minNoise = currentNoise;
        }
    }

    if (minNoise.length() == 0)
    {
        cout << "no noise" << endl;
    }
    else
    {
        cout << minNoise << endl;
    }

    return 0;
}
