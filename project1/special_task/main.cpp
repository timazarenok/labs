#include <iostream>
#include "unarypredicate.h"
#include "task0.h"
#include "BinaryOperations.h"
#include <cmath>

using namespace std;

using BinaryOperation = int (*)(int, int);
using UnaryPredicate = bool (*)(int);

int task1(int* arr, int size, UnaryPredicate p)
{
    int temp = 0;
    for(int i = 0; i < size; ++i)
    {
        if(p(arr[i]))
        {
            temp = temp + arr[i];
        }
    }
    return temp;
}
int task1_2(int* arr, int size, UnaryPredicate p)
{
    int temp = 1;
    for(int i = 0; i < size; ++i)
    {
        if(p(arr[i]))
        {
            temp = temp * arr[i];
        }
    }
    return temp;
}
int task2(int* arr, int size, UnaryPredicate p)
{
    int temp = 1;
    for(int i = 0; i < size; ++i)
    {
        if(p(arr[i]))
        {
            temp = temp * arr[i];
        }
    }
    return temp;
}
int task2_1(int* arr, int size, UnaryPredicate p)
{
    int temp = 0;
    for(int i = 0; i < size; ++i)
    {
        if(p(arr[i]))
        {
            temp = temp + arr[i];
        }
    }
    return temp;
}
int task3(int* arr, int size, UnaryPredicate p)
{
    int sum = 0;
    int sum1 = 0;
    for(int i = 0; i < size; ++i)
    {
        if(p(arr[i]))
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}
int task3_1(int* arr, int size, UnaryPredicate p)
{
    int sum1 = 0;
    for(int j = 0; j < size; ++j)
    {
        if(p(arr[j]))
        {
            sum1 = sum1 + abs(arr[j]);
        }
    }
    return sum1;
}
int min_element(int* arr, int size)
{
    int min = 0;
    for(int i = 0; i < size; ++i)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}
int max_element(int* arr, int size)
{
    int max = 0;
    for(int i = 0; i < size; ++i)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

int main()
{
    int arr[5];
    print_array(arr, 5);
    int result_taskA1 = task1(arr, 5, is_positive);
    int result_taskA1_2 = task1_2(arr, 5, is_negative);
    int result_taskA2 = task2(arr, 5, is_even);
    int result_taskA2_1 = task2_1(arr, 5, is_negative);
    int result_task3 = task3(arr, 5, is_positive);
    int result_task3_1 = task3_1(arr, 5, is_negative);
    int result_subtraction_task3 = subtraction(result_task3, result_task3_1);
    int result_min_element = min_element(arr,5);
    int result_max_element = max_element(arr,5);
    int sum_min_max = accumulate(result_min_element,result_max_element);
    cout << endl;
    cout << "TASK1: ";
    cout << "sum of positive elements = " << result_taskA1 << ";" << endl;
    cout << "composition of negative elements = " << result_taskA1_2 << ";" << endl;
    cout << endl;
    cout << "TASK2: ";
    cout << "composition of even elements = " << result_taskA2 << ";" << endl;
    cout << "sum of negative elements = " << result_taskA2_1 << ";" << endl;
    cout << endl;
    cout << "TASK3: ";
    cout << "sum of positive elements of array = " << result_task3 << endl;
    cout << "sum of abs-negative elements of array = " << result_task3_1 << endl;
    cout << "subtraction = " << result_subtraction_task3 << endl;
    cout << endl;
    cout << "TASK4:";
    cout << " min element = " << result_min_element << ";" <<endl;
    cout << " max element = " << result_max_element << ";" <<endl;
    cout << " sum = " << sum_min_max << ";" <<endl;



    return 0;
}
