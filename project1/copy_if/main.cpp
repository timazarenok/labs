#include <iostream>

template<class InputIt, class OutputIt, class UnaryPredicate>
OutputIt copy_if(InputIt first, InputIt last,
                 OutputIt d_first, UnaryPredicate pred)
{
    while (first != last) {
        if (pred(*first))
            *d_first++ = *first;
        first++;
    }
    return d_first;
}

bool is_even(int a)
{
    return a % 2 == 0;
}

int main()
{
    int arr[4]{2,3,4,8};
    int arr1[4]{0};
    std::cout << copy_if(arr, arr + 4, arr1, is_even) << std::endl;
    for(int i = 0; i < 4; ++i)
    {
        std::cout << *(arr + i) << " ";
    }
    for(int i = 0; i < 4; ++i)
    {
        std::cout << *(arr1 + i) << " ";
    }
    return 0;
}
