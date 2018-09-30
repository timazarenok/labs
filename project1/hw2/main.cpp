#include <iostream>
#include "operation.h"
#include "predicates.h"
using BinaryOperation = int (*)(int, int);
using BinaryPredicate = bool (*)(int, int);
using UnaryPredicate = bool (*)(int);
using namespace std;

int find_if_value(int* array, int first, int last, int predicate_operant, BinaryPredicate p)
{
    for( ; first < last; ++first)
    {
        if(p(array[first], predicate_operant))
        {
            return first;
        }
    }
    return -1;
}
int find_index_if(int* array, int first, int last, UnaryPredicate p)
{
    for( ; first < last; ++first)
    {
        if(p(array[first]))
        {
            return first;
        }
    }
    return -1;
}
void print_array_if_task_7(int* array, int first, int last, UnaryPredicate p)
{
    for( ;first < last; ++first)
    {
        if(p(array[first]))
        {
            cout << array[first];
        }
    }
}
int accum(int* array, int first, int last, int result, BinaryOperation operation)
{
    for( ;first < last; ++first)
    {
        result = operation(result, array[first]);
    }
    return result;
}

int main()
{
    int array[10]{1,2,3,4,5,6,7,8,9,10};
    int result = find_if_value(array, 0, 10, array[9], stu::greater);
    //int result = find_index_if(array, 0, 10, is_even);
    //int result = accum(array, 0, 10, 1000, sum);
    //print_array_if_task_7(array , 0, 10 , is_even);
    cout<< result <<endl;

    return 0;
}
