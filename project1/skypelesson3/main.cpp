#include <iostream>
#include "algoritsm.h"
#include "Predicates.h"


using namespace std;



void print_array(int* arr, int size)
{
    for(int i = 0; i < size; ++i)
    {
        cout<< arr[i] << " ";
    }
}

int* task3(int* arr, int size)
{
    int j = 0;
    int* result = new int[size];
    for(int i = 0; i < size; i+=2, ++j)
    {
        result[j] = arr[i];
    }
    for(int i = 1; i < size; i+=2, ++j)
    {
        result[j] = arr[i];
    }
    return result;
}

int* get_negative_elements(int* arr, int size)
{
    int temp = count_if(arr, size, is_negative);
    int* result = new int[temp];
    copy_if(result, arr, size, is_negative);
    return result;
}

int* get_positive_elements(int* arr, int size)
{
    int temp = count_if(arr, size, is_positive);
    int* result1 = new int[temp];
    copy_if(result1, arr, size, is_positive);
    return result1;
}

void change_elements(int* arr, int size, UnaryPredicate p, int value)
{
    for(int i = 0; i < size; ++i)
    {
        if(p(arr[i]))
        {
            arr[i] = value;
        }
    }
}

int main()
{
    int arr[10] {3, 2, -3, 2, 5, 1, 1, -1, -5, -2};
    int arr1[10]{0};
    int* result3 = task3(arr, 10);
    print_array(result3, 10);
    /*copy_if(arr1, arr, 10, is_positive);
    print_array(arr1, 10);
    cout<< " last positive argument = " << find_if(arr, 10, is_positive) <<endl;
    int result = accumulate(arr, arr + find_if(arr, 10, is_positive), 0);
    cout<< " sum = " << result <<endl;
    int* result1 = get_negative_elements(arr, 10);
    print_array(result1, 4);
    delete[] result1;
    change_elements(arr, 10, is_one, 10);
    print_array(arr, 10);
    */
    return 0;
}

