#include <iostream>
#include <vector>
#include <string>
#include <list>
#include <sstream>
#include <climits>

using namespace std;

void readTrain(list<int>& track)
{
    string buf;
    getline(cin, buf); // Read track A
    istringstream sBuf(buf);
    int car;
    while (sBuf >> car)
    {
        track.push_front(car);
    }
}

void printTrain(const list<int>& train)
{
    for (int car : train) { cout << car << ' '; }
    cout << endl;
}

list<char> brackets;

bool isCurvedBracketAllowed()
{
    return true;
}

bool isSqueredBracketAllowed()
{
    if (brackets.size() == 0) { return true; }
    list<char>::iterator itB = brackets.end();
    itB--;
    while (true) {
        if (*itB == '(')
        {
            return false;
        }
        if (itB == brackets.begin())
        {
            break;
        }
        itB--;
    }
    return true;
}

bool isCurlyBracketAllowed()
{
    if (brackets.size() == 0) { return true; }
    list<char>::iterator itB = brackets.end();
    itB--;
    while (true) {
        if (*itB == '(' || *itB == '[')
        {
            return false;
        }
        if (itB == brackets.begin())
        {
            break;
        }
        itB--;
    }
    return true;
}

bool popBracket(char bracket)
{
    if (brackets.size() == 0) { return false; }
    char back = brackets.back();
    brackets.pop_back();

    if (bracket == ')' && back == '(')
    {
        return true;
    }
    if (bracket == ']' && back == '[')
    {
        return true;
    }
    if (bracket == '}' && back == '{')
    {
        return true;
    }

    return false;
}

bool isOpeningBracketAllowed(char bracket)
{
    switch (bracket)
    {
    case '(': return isCurvedBracketAllowed();
    case '[': return isSqueredBracketAllowed();
    case '{': return isCurlyBracketAllowed();
    default: return false;
    }
}

bool isCorrectSequence(const string& line)
{
    for (char buf : line)
    {
        switch (buf)
        {
        case '(':
        case '[':
        case '{':
            if (isOpeningBracketAllowed(buf))
            {
                return false;
            }
            else
            {
                brackets.push_back(buf);
            }
            break;

        case ')':
        case ']':
        case '}':
            if (!popBracket(buf))
            {
                return false;
            }
            break;

        default:
            return false;
        }
    }
    return true;
}

unsigned stringToTime(const string& time)
{
    unsigned h = (time[0] - '0') * 10 + (time[1] - '0');
    unsigned m = (time[2] - '0') * 10 + (time[3] - '0');
    return h * 60 + m;
}

unsigned calcWaitTime(unsigned busArrival, unsigned trainDeparture)
{
    if (busArrival >= trainDeparture)
    {
        return busArrival - trainDeparture;
    }
    else
    {
        return (24 * 60 - trainDeparture) + busArrival;
    }
}

int main()
{
    /*list<int> trackA;
    list<int> trackB;
    list<int> merged;
    readTrain(trackA);
    readTrain(trackB);
    string mergeInstr;

    list<int>::iterator itA = trackA.begin();
    list<int>::iterator itB = trackB.begin();

    while (itA != trackA.end() || itB != trackB.end())
    {
        if (itA != trackA.end() && itB != trackB.end())
        {
            if (*itA < *itB)
            {
                mergeInstr += 'A';
                merged.push_front(*itA);
                ++itA;
            }
            else
            {
                mergeInstr += 'B';
                merged.push_front(*itB);
                ++itB;
            }
        }
        else
        {
            if (itA != trackA.end())
            {
                mergeInstr += 'A';
                merged.push_front(*itA);
                ++itA;
            }
            else
            {
                mergeInstr += 'B';
                merged.push_front(*itB);
                ++itB;
            }
        }
    }
    cout << mergeInstr << endl;
    printTrain(merged);*/

    /*string line; cin >> line;
    cout << (isCorrectSequence(line) ? "valid" : "invalid") << endl;*/

    /*unsigned pipes;
    vector<int> a;
    vector<int> b;
    cin >> pipes;
    a.resize(pipes);
    b.resize(pipes);
    unsigned cur;
    for (cur = 0; cur < pipes; cur++)
    {
        cin >> a[cur];
    }
    for (cur = 0; cur < pipes; cur++)
    {
        cin >> b[cur];

    }
    for (cur = 0; cur < pipes; cur++)
    {
        unsigned k = b[cur] - a[cur];
        unsigned lifetime = b[cur] / k;
        cout << lifetime << ' ';

    }
    cout << endl;*/

    size_t buses;
    cin >> buses;
    vector<unsigned> times(buses);
    for (size_t cur = 0; cur < buses; cur++) {
        string curTimeStr;
        cin >> curTimeStr;
        times[cur] = stringToTime(curTimeStr);
    }

    string trainLeaveStr;
    cin >> trainLeaveStr;
    unsigned trainLeaveTime = stringToTime(trainLeaveStr);
    size_t busIndex;
    unsigned minWaitTime = UINT_MAX;

    for (size_t cur = 0; cur < buses; cur++)
    {
        unsigned waitTime = calcWaitTime(times[cur], trainLeaveTime);
        if (waitTime < minWaitTime)
        {
            minWaitTime = waitTime;
            busIndex = cur;
        }
    }
    cout << busIndex + 1;

    return 0;
}
