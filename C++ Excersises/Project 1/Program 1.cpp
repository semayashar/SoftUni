#include <iostream>
using namespace std;

int main()
{
    int in;
    cin >> in;
    int A[10][10];
    int sum = 0;

    for (int i = 0; i < in; i++)
    {
        for (int y = 0; y < in; y++)
        {
            cin >> A[i][y];
        }
    }

    for (int i = 0; i < in; i++)
    {
        for (int y = 0; y < in; y++)
        {
            if (i == y || i == in - 1 - y)
            {
                A[i][y] = 0;
            }
        }
    }

    for (int i = 0; i < in; i++)
    {
        for (int y = 0; y < in; y++)
        {
            if (A[i][y] % 2 != 0)
            {
                sum += A[i][y];
            }
        }
    }

    cout << "The sum is: " << sum << endl;

    return 0;
}
