#include <iostream>

using namespace std;

void definition_of_numbers(int number)
{
    int sum = 0;
    for(int i = 10, j = 1, g = 0; g < 4; i*=10)
    {
        ++g;
        int temp = number;
        temp = temp%i;
        temp = temp/j;
        j*=10;
        cout << temp <<endl;
        sum += temp;
    }
    cout << "sum = " << sum << endl;
}

int main()
{
    definition_of_numbers(2586);
    return 0;
}
