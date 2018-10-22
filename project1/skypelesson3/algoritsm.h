#ifndef ALGORITSM_H_INCLUDED
#define ALGORITSM_H_INCLUDED




using UnaryPredicate = bool (*)(int);



int count_if(int* arr, int size, UnaryPredicate p)
{
    int temp = 0;
    for(int i = 0; i < size; ++i)
    {
        if(p(arr[i]))
        {
            ++temp;
        }
    }
    return temp;

}

void copy_if(int* dest, int* src, int size, UnaryPredicate p)
{
    for(int i = 0, j = 0; i < size; ++i)
    {
        if(p(src[i]))
        {
            dest[j] = src[i];
            ++j;
        }

    }
}

int find_if(int* arr, int size, UnaryPredicate p)
{
    --size;
    for ( ; size > -1; --size)
    {
        if (p(arr[size]))
            return size;
    }
    return -1;
}

int accumulate(int* first, int* last, int temp)
{
    for ( ; first < last; ++first)
    {
        temp += (*first);
    }
    return temp;
}


#endif // ALGORITSM_H_INCLUDED
