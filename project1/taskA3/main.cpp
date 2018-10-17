#include <iostream>

using namespace std;

int third_number_of_digit(int digit)
{
    int third_number = digit%1000;
    third_number = third_number/100;
    return third_number;
}

int main()
{
    int result = third_number_of_digit(4567);
    cout<< "third number = " << result <<endl;
    return 0;
}
