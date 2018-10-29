#ifndef BINARYOPERATIONS_H_INCLUDED
#define BINARYOPERATIONS_H_INCLUDED
#include <cmath>
int accumulate(int a, int b)
{
    a = a + b;
    return a;
}
int subtraction(int a, int b)
{
    return a - b;
}
void swap(int a, int b)
{
    int temp = b;
    b = a;
    a = temp;
}


#endif // BINARYOPERATIONS_H_INCLUDED
