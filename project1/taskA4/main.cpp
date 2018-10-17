#include <iostream>

using namespace std;

int defenition_digit(int v)
{
    int temp = 0;
    for(; v!=0; v=v/10)
    {
        temp = temp*10;
        temp = temp + (v%10);

    }
     return temp;

}
bool is_polindrom(int value)
{
    return defenition_digit(value) == value;
}


int main()
{
    int result = is_polindrom(1221);
    cout <<  " " << result <<endl;
    return 0;
}
