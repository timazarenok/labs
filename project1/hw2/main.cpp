#include <iostream>

using UnaryPredicate = bool (*)(int a);
using namespace std;
bool is_even(int a)
{
    return a%2==0;
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

int main()
{
    int array[10]{1,2,3,4,5,6,7,8,9,10};
    print_array_if_task_7(array , 0, 10 , is_even);

    return 0;
}
