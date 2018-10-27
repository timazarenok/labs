#ifndef UNARYPREDICATE_H_INCLUDED
#define UNARYPREDICATE_H_INCLUDED
#include <cmath>
bool is_positive(int a)
{
    return a > 0;
}
bool is_negative(int a)
{
    return a < 0;
}
bool is_even(int a)
{
    return a%2==0;
}
bool is_abs(int a)
{
    return abs(a);
}



#endif // UNARYPREDICATE_H_INCLUDED
