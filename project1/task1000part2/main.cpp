#include <iostream>
#include <cmath>

using namespace std;

void f1(int* array, int size)
{
    int max_el = 0;
    int min_el = 0;
    for(int i = 0; i < size; ++i)
    {
        if(array[i] > max_el)
        {
            max_el = array[i];
        }
        if(array[i] < min_el)
        {
            min_el = array[i];
        }
    }
    cout << min_el << " " << max_el;
}
void f2(int* array, int size)
{
    int min_el = 0;
    int min_ind = 0;
    for(int i = 0; i < size; i++)
    {
        if(array[i] < min_el)
        {
            min_el = array[i];
            min_ind = i;
        }
    }
    cout << min_ind;
}
void f3(int* array, int size)
{
    int max_el = 0;
    int min_el = 0;
    for(int i = 0; i < size; ++i)
    {
        if(array[i] > array[i+1])
        {
            max_el = array[i];
        }
        if(array[i] < min_el)
        {
            min_el = array[i];
        }
    }
    cout << min_el << " " << max_el;
}
void f4(int* array, int size)
{
    int max_el = 0;
    int max_ind = 0;
    int final_min_el = 0;
    int final_min_ind = 0;
    for(int i = 0; i < size; ++i)
    {
        if(array[i] > array[i+1])
        {
            max_el = array[i];
            max_ind = i;
        }
        if(array[i] < final_min_el)
        {
            final_min_el = array[i];
            final_min_ind = i;
        }
    }
    cout << max_ind << " " << final_min_ind;
}
void f5(int* array, int size)
{
    for(int i = size-1; i >= 0; --i)
    {
        cout << array[i] << endl;
    }
}
void f6(int* array, int size)
{
    for(int i = 0; i < size; ++i)
    {
        if(array[i]%2 != 0)
        {
            cout << i << endl;
        }
    }
}
void f7(int* array, int size)
{
    int counter = 0;
    for(int i = size-1; i >= 0; --i)
    {
        if(array[i]%2 == 0)
        {
            cout << i << endl;
            ++counter;
        }
    }
    cout << counter << endl;
}
void f8(int* array, int size)
{
    for(int i = 0; i < size; ++i)
    {
        if(array[i]%2 == 0)
        {
            cout << i << endl;
        }
    }
    cout << endl;
    for(int j = size-1; j >= 0; --j)
    {
        if(array[j]%2 != 0)
        {
            cout << j << endl;
        }
    }
}
void f9(int* array, int size, int n)
{
    for(int i = 0; i < size; ++i)
    {
        if(array[i]%n == 0)
        {
            cout << array[i] << endl;
        }
    }
}
void f10(int* array, int size)
{
    for(int i = 0; i < size; i = i+2)
    {
        cout << array[i];
    }
}
void f11(int* array, int size)
{
    for(int i = size-1; i > 0; i= i - 2)
    {
        cout << array[i] << endl;
    }
}
void f12(int* array, int size)
{
    for(int i = 0; i < size; i = i + 2)
    {
        cout << array[i];
    }
    cout << " " ;
    for(int j = 1; j < size; j = j + 2)
    {
        cout << array[j];
    }
}
void f13(int* array, int size)
{
    for(int i = 1; i < size; i = i + 2)
    {
        cout << array[i];
    }
    cout << " " ;
    for(int j = size-1; j >= 0; j = j - 2)
    {
        cout << array[j];
    }
}
void f14(int* array, int size)
{
    for(int i = 0, j = size-1; i < j; ++i, --j)
    {
        cout << array[i] << " " << array[j] << " ";
    }
}
void f15(int* array, int size)
{
    for(int i = 0, j = size - 1; i < j; ++i, --j)
    {
        cout << array[i] << " " << array[i+1] << endl;
        cout << array[j] << " " << array[j-1] << endl;
    }
}
int f16(int* array, int size)
{
    int min_el = array[size-1];
    for(int i = 0; i < size; ++i)
    {
        if(array[i] < min_el)
        {
           min_el = array[i];
           return min_el;
        }
    }
}
int f17(int* array, int size)
{
    int min_el = array[size-1];
    for(int i = 1; i < size; ++i)
    {
        if((array[0] < array[i]) && (array[i] < min_el))
        {
            min_el = array[i];
            return min_el;
        }
    }
}
int f18(int* array, int size, int k, int l)
{
    int sum = 0;
    for(int i = k; i < l; ++i)
    {
        sum += array[i];
    }
    return sum;
}
int f19(int* array, int size,int k, int l)
{
    int middle_result = 0;
    int sum = 0;
    int denum = l-k+1;
    for(int i = k; i < l; ++i)
    {
        sum += array[i];
        middle_result = sum/denum;
    }
    return middle_result;
}
int f20(int* array, int size, int k, int l)
{
    int sum1 = 0;
    int sum2 = 0;
    int sum = 0;
    for(int i = 0; i < k; ++i)
    {
        sum1 += array[i];
    }
    for(int j = size-1; j > l; --j)
    {
        sum2 += array[j];
    }
    sum = sum1 + sum2;
    return sum;
}
int f21(int* array, int size, int k, int l)
{
    int middle_result = 0;
    int sum = 0;
    int sum1 = 0;
    int sum2 = 0;
    int denum = 0;
    for(int i = 0; i < k; ++i)
    {
        sum1 += array[i];
        denum++;
    }
    for(int j = size-1; j > l; --j)
    {
        sum2 += array[j];
        denum++;
    }
    sum = sum1 + sum2;
    middle_result = sum/denum;
    return middle_result;
}
int f22(int* array, int* array1, int size, int a, int D)
{
    for(int i = 0; i < size; ++i)
    {
        array1[i] = a + i * D;
    }
    for(int j = 0; j < size; ++j)
    {
        if(array1[j] != array[j])
        {
            return false;
        }
    }
    return D;
}
int f23(int* array, int* array1, int size, int a, int D)
{
    for(int i = 0; i < size; ++i)
    {
        array1[i] = a * pow(D,i);
    }
    for(int j = 0; j < size; ++j)
    {
        if(array1[j] != array[j])
        {
            return false;
        }
    }
    return D;
}

int f24(int* array, int size)
{
    int min_el = array[0];
    for(int i = 0; i < size; i = i + 2)
    {
        if(min_el > array[i])
        {
            min_el = array[i];
        }
    }
    return min_el;
}

int f25(int* array, int size)
{

    int max_el = array[0];
    for(int i = 1; i < size; i = i + 2)
    {
        if(max_el < array[i])
        {
            max_el = array[i];
        }
    }
    return max_el;
}

int f26(int* array, int size)
{
    int temp = 0;
    for(int i = 0; i < size-1; ++i)
    {
        if(array[i] > array[i+1])
        {
            temp++;
            cout << i << endl;
        }
    }
    return temp;
}

int f27(int* array, int size)
{
    int temp = 0;
    for(int i = 1; i < size; ++i)
    {
        if(array[i] > array[i-1])
        {
            temp++;
            cout << i << endl;
        }
    }
    return temp;
}
int main()
{
    int array[10]{6,2,4,67,5,6,7,8,9,10};
    int array1[10]{0};
    //f1(array, 10);
    //f2(array, 10);
    //f3(array, 10);
    //f4(array, 10);
    //f5(array,10);
    //f6(array, 10);
    //f7(array, 10);
    //f8(array, 10);
    //f9(array, 10, 5);
    //f10(array, 10);
    //f11(array, 10);
    //f12(array, 10);
    //f13(array, 10);
    //f14(array, 10);
    //f15(array, 10);
    //cout << f16(array, 10) << endl;
    //cout << f17(array, 10) << endl;
    //cout << f18(array, 10, 4, 8);
    //cout << f19(array, 10, 4, 8) << endl;
    //cout << f20(array, 10, 4, 8) << endl;
    //cout << f21(array, 10, 4, 8) << endl;
    //cout << f22(array, array1, 10, 1, 1) << endl;
    //cout << f23(array, array1, 10, 1, 1) << endl;
    //cout << f24(array, 10) << endl;
    //cout << f25(array, 10) << endl;
    //cout << f26(array, 10) << endl;
    //cout << f27(array, 10) << endl;
    cout << " " << endl;
    return 0;
}
