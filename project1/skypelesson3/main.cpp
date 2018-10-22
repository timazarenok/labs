#include <iostream>


using UnaryPredicate = bool (*)(int, int);

using namespace std;
int find_positive(int* arr, int size)
{
    --size;
    for ( ; size > -1; --size)
    {
        if (arr[size] > 0)
            return size;
    }
    return -1;
}

int accumulate(int* first, int* last, int temp)
{
    for ( ; first < last; ++first)
    {
        temp += (*first);
    }
    return temp;
}

int main()
{
    int arr[10] {1, 1, -3, 1, 1, 1, 1, -1, -5, -2};
    cout << find_positive(arr,10) << endl;
    int result = accumulate(arr, arr+find_positive(arr, 10), 0);
    cout<< "sum = " << result << endl;
    return 0;
}

