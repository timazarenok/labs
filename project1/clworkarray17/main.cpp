#include <iostream>

using namespace std;
void array_task17(int* array, int size)
{
    for(int i = 0,  j = size-1; i < size; )
    {
        for(int k = 0; k < 2; ++k)
        {
            cout<< array[i] <<endl;
            ++i;
        }
        for(int k = 0; k < 2; ++k)
        {
            cout<< array[j] << endl;
            --j;
        }
    }
}
int main()
{
    int array[10]{1,2,3,4,5,6,7,8,9,10};
    array_task17(array, 10);

    return 0;
}
