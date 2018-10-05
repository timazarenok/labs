#include <iostream>

using namespace std;
int f(int a, int key)
{
    return a^key;
}
int copy(int* dest, int* src, int size, int key)
{
    for(int i=0; i < size; ++i)
    {
        dest[i] = f(src[i],key);
        cout<< dest[i] <<endl;
    }
}
void print_array(int* array, int size)
{
    for(int i = 0; i < size; ++i)
    {
        cout<< array[i] <<endl;
    }
    cout << endl;
}
int main()
{
    int array[10]{1,2,3,4,5,6,7,8,8,9};
    print_array(array, 10);
    int dest[10]{0};
    int src[10]{1,2,3,4,5,6,7,8,9,10};
    int result =  copy(dest, src, 10, 2);
    cout << result << endl;
    return 0;
}
