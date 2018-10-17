#include <iostream>

using namespace std;

void defenition_of_numbers(int number)
{
    for(int i = 10, j = 1, g = 0; g < 4; i= i*10)
    {
        ++g;
        int temp = number;
        temp = temp%i;
        temp = temp/j;
        j*=10;
        cout << temp << endl;
    }
}

int main()
{

    defeninion_of_numbers(3456);
    return 0;
}
