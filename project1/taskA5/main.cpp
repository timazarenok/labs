#include <iostream>

using namespace std;

bool is_even_numbers(int v)
{
    int counter = 0;
    for(; v!=0; v = v/10)
    {
        for(int i = v/10; i!= 0; i = i/10)
        {
            if(i%10 == v%10)
            {
                ++counter;
            }
        }
    }
    return  counter == 1;
}
int main()
{
    int result = is_even_numbers(2213);
    cout << result << endl;
    return 0;
}
