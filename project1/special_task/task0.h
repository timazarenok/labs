#ifndef TASK0_H_INCLUDED
#define TASK0_H_INCLUDED
#include <iostream>

void print_array(int* arr, int size)
{
    std::cout << "Array of my tasks :" << std::endl;
    for(int i = 0; i < size; ++i)
    {

        std::cout << "arr[" << i << "] = ";
        std::cin >> arr[i];
    }
}


#endif // TASK0_H_INCLUDED
