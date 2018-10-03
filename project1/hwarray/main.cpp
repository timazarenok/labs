#include <iostream>

using namespace std;
struct Point
{
    int m_x;
    int m_y;
    Point()
    {
        m_x = 0;
        m_y = 0;
    }
    Point(int x, int y)
    {
        m_x = x;
        m_y = y;
    }
};

int get_index_reverse(Point* array, int size)
{
    for(int i = size-1; i > -1; --i)
    {
        if(array[0].m_x < array[i].m_x && array[i].m_x < array[size-1].m_x)
        {
            return i;
        }
    }
    return -1;
}

int get_index(Point* array, int size)
{
    for(int i = 0; i < size; ++i)
    {
        if(array[i].m_x < array[size-1].m_x && array[0].m_x < array[i].m_x)
        {
            return i;
        }
    }
    return -1;
}

int main()
{
    Point array[5] {Point(1,2), Point(3,4), Point(5,6), Point(7,8), Point(9,10) };
    int result = get_index(array, 5);
    int result1 = get_index_reverse(array, 5);
    std::cout << result <<std::endl;
    std::cout << result1 <<std::endl;
    return 0;
}
