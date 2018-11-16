#include <iostream>

using namespace std;
int f(int a)
{
    int temp = 1;
    for(int i = 1; i <= a; ++i)
    {
        temp *= i;
    }
    return temp;
}
int main()
{
    int result = f(5);
    cout << result << endl;
    return 0;
}
