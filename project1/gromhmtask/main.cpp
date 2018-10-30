#include <iostream>

using BinaryOperation = int (*)(int, int);
using namespace std;

int mul(int a, int b)
{
    return a*b;
}

int accumulate(int* arr, int first, int last, int temp, BinaryOperation p)
{
    for(; first < last; ++first)
    {
        temp = p(temp, arr[first]);
    }
    return temp;
}

int find_(int* arr, int first, int last, int value)
{
    for(; first < last; ++first)
    {
        if(arr[first] == value)
        {
            return first;
        }
    }
}

int f(int* arr, int first, int last)
{
    int start = find_(arr, first, last, 0);
    int end = find_(arr, start+1, last, 0);
    return accumulate(arr, start+1, end, 1, mul);

}



int main()
{
    int arr[10]{1, 0, 2, 4, 5, 6, 0, 7, 5, 10};
    int result = f(arr, 0, 10);
    cout << result << endl;
    return 0;
}
