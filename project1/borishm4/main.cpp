#include <iostream>

using namespace std;

int main()
{
    int size=10;
    int tima_luchiy[10] {0};
    int array[10] {70,54,100,5,42,6,7,4,9,10};
    for(int i=0; i<size; ++i)
    {
        if(array[i]%7==0)
        {
            tima_luchiy[i]=array[i];
        }

    }

    for(int i = 0; i < size; ++i)
    {
        for(int j=0; j < size-i-1; ++j)
        {
            if(tima_luchiy[j] < tima_luchiy[j+1])
            {
                int temp = tima_luchiy[j];
                tima_luchiy[j] = tima_luchiy[j+1];
                tima_luchiy[j+1] = temp;
            }
        }
    }
    for(int i = 0; i < size ; ++i)
    {
        cout << tima_luchiy[i] <<endl;
    }

    return 0;
}
