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


#endif // PREDICATES_H_INCLUDED
