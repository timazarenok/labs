#ifndef PREDICATES_H_INCLUDED
#define PREDICATES_H_INCLUDED

bool is_positive(int a)
{
    return a > 0;
}

bool is_negative(int a)
{
    return !is_positive(a);
}

bool is_one(int a)
{
    return abs(a) == 1;
}


#endif // PREDICATES_H_INCLUDED
