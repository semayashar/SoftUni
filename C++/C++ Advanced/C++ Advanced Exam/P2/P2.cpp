#include <iostream>
using namespace std;

void convertDiagonalZeros(int** matrix, int N) {
    // Convert main diagonal elements to 0
    for (int i = 0; i < N; i++) {
        matrix[i][i] = 0;
    }

    // Convert secondary diagonal elements to 0
    for (int i = 0; i < N; i++) {
        matrix[i][N - i - 1] = 0;
    }
}

int main() {
    int N;
    cin >> N;

    int** matrix = new int* [N];
    for (int i = 0; i < N; i++) {
        matrix[i] = new int[N];
    }

    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            int curNum;
            cin >> curNum;
            matrix[i][j] = curNum;
        }
    }

    convertDiagonalZeros(matrix, N);
    int sum = 0;

    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            if (matrix[i][j] % 2 != 0) {
                sum += matrix[i][j];
            }
        }
    }

    cout << "The sum is: " << sum << endl;

    for (int i = 0; i < N; i++) {
        delete[] matrix[i];
    }
    delete[] matrix;

    return 0;
}
