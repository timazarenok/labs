#include <iostream>
#include <cmath>
using namespace std;

int main()
{

    int array[5]= {1,2,3,4,5};
    int last = array[4];
    int y = 1;
    for(int i=0; i<last; ++i)
    {
        int x = array[i];
        double result = sqrt(pow(((cos(x-y)-cos(x+y))/2),2)*(pow((sin(x)*sin(y)),2)/(pow(sin(x),2)+pow(cos(x),2))));
        cout<< result << endl;

    }
    return 0;
}

