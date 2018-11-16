#include <iostream>
#include <cmath>
#include "algoritms.h"
#define PI 3.14
using namespace std;
void f1(int*array, int size)
{
    for(int i = 0, j = 2; i < size; ++i , j=j*2)
    {
        array[i] = j;
        cout << array[i] <<endl;
    }
}
void f2(int* array, int size)
{
    for(int i = 1; i < size; i=i+2)
    {
        array[i] = i;
        cout << array[i] <<endl;
    }
}
void f3(int* array, int size, int a, int d)
{
    for(int i = 0; i < size; ++i)
    {
        array[i] = a + i*d;
        cout << array[i] <<endl;
    }
}
void f4(int* array, int size, int a, int d)
{
    for(int i = 0; i < size; ++i)
    {
        array[i] = a * pow(d,i);
        cout << array[i] <<endl;
    }
}
void f5(int* array, int size)
{
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < size; ++i)
    {
        array[i] = array[i-2] + array[i-1];
        cout << array[i] << endl;
    }
}
int f6(int a)
{
    return 4*a;
}
int f7(int a)
{
    return pow(a,2);
}
void f8(int a, int b)
{
    int s = a*b;
    cout << s <<endl;
    int p = 2*(a+b);
    cout << p << endl;
}
void f9(int d)
{
    double l = d * PI;
    cout << l << endl;
}
void f10(int a)
{
    int v = pow(a,3);
    cout << v << endl;
    int s = 6 * pow(a,2);
    cout << s << endl;
}
void f11(int a, int b, int c)
{
    int v = a * b * c;
    cout << v << endl;
    int s = 2 * (a*b + b*c + a*c);
    cout << s << endl;
}
void f12(int r)
{
    double l = 2 * PI * r;
    cout << l << endl;
    double s = PI * pow(r,2);
    cout << s << endl;
}
void f13(double a, double b)
{
    cout << (a+b)/2 << endl;
}
void f14(int a, int b)
{
    cout << sqrt(abs(a)*abs(b)) << endl;
}
void f15(double a, double b)
{
    int sum = a + b;
    cout << sum << endl;
    int sub = a-b;
    cout << sub << endl;
    int mul = a * b;
    cout << mul << endl;
    double temp = pow(a,2)/pow(b,2);
    cout << temp << endl;
}
void f16(double a, double b)
{
    int sum = a + b;
    cout << sum << endl;
    int sub = a-b;
    cout << sub << endl;
    int mul = a * b;
    cout << mul << endl;
    double temp = abs(a)/abs(b);
    cout << temp << endl;
}
void f17(double a, double b)
{
    double c = sqrt(pow(a,2)+pow(b,2));
    cout << c << endl;
    double p = a + b + c;
    cout << p << endl;
}
void f18(int r1, int r2)
{
    double s1 = 0;
    double s2 = 0;
    double s3 = 0;
    if(r1 > r2)
    {
        s1 = PI * pow(r1,2);
        s2 = PI * pow(r2,2);
        s3 = s1 - s2;
        cout << s1 << " " << s2 << " " << s3 << endl;
    }
    else
    {
        cout << " r1 < r2" << endl;
    }
}
void f19(int l)
{
    double r = l/(2*PI);
    cout << r << endl;
    double s = PI * pow(r,2);
    cout << s << endl;
}
void f20(int s)
{
    double d = sqrt((s*4)/PI);
    cout << d << endl;
    double l = PI * d;
    cout << l << endl;

}
void f21(int x1, int x2)
{
    int x3 = abs(x1-x2);
    cout << x3 << endl;
}
void f22(int a, int b, int c)
{
    int ac = abs(c-a);
    cout << ac << endl;
    int bc = abs(c-b);
    cout << bc << endl;
    int sum = ac + bc;
    cout << sum << endl;
}
void f23(int a, int b, int c)
{
    int ac = 0;
    int bc = 0;
    int mul = 0;
    if(c > a && c < b)
    {
        ac = abs(c-a);
        bc = abs(c-b);
        mul = ac * bc;
        cout << ac << " " << bc << " " << mul << endl;
    }
    else
    {
        cout << " c was not found" <<endl;
    }
}
void f24(int x1, int y1, int x2, int y2)
{
    double S = sqrt(pow(x2-x1,2)+pow(y2-y1,2));
    cout << S << endl;
}
void f25(int a, int b)
{
    int temp = a;
    a = b;
    b = temp;
    cout << a << " " << b << endl;
}
void f26(int a, int b, int c)
{
    int temp = a;
    a = b;
    b = c;
    c = temp;
    cout << a << " " << b << " " << c << endl;
}
void f27(int a, int b, int c)
{
    int temp = c;
    c = a;
    a = b;
    b = temp;
    cout << a << " " << b << " " << c << endl;
}
void f28(int x)
{
    int y = (3 * pow(x,6)) - (6 * pow(x,2)) - 7;
    cout << y << endl;
}
void f29(int x)
{
    int y = (4 * pow(x-3,6)) - (7 * pow(x-3,3)) + 2;
    cout << y << endl;
}
void f30(int* array, int size, int a)
{
    for(int i = 0, j = 2; i < size; ++i)
    {
        array[i] = pow(a,j);
        cout << array[i] << endl;
        j = j*2;
    }
}
void f31(double Tf)
{
    double Tc = (Tf - 32) * (5.0/9.0);
    cout << Tc << endl;
}
void f32(double Tc)
{
    double Tf = (Tc * (9.0/5.0)) + 32;
    cout << Tf << endl;
}
void f33(int x, int A, int y)
{
    int z = A/x;
    int Ay = z * y;
    cout << " price of y kg = " << Ay << " price of 1 kg = " << z << endl;
}
void f34(int x, int A, int y, int B)
{
    double price = A/x;
    double price1 = B/y;
    double price2 = price/price1;
    cout << price2 << endl;
}
void f35(double v, double u, double t, double t1)
{
    if(u < v)
    {
        double v1 = v - u;
        double s = v * t;
        double s1 = v1 * t1;
        cout << s << " " << s1 << endl;
    }
    else
    {
        cout << " u > v " << endl;
    }


}
void f36(int v1, int v2, int s, int t)
{
    double v = v1 + v2;
    double s1 = t* v;
    double s2 = s1 + s;
    cout<<s2<<endl;
}
void f37(int v1, int v2, int s, int t)
{
    double v = v1 + v2;
    double s1 = t* v;
    double s2 = abs(s - s1);
    cout<<s2<<endl;
}
void f38(int a, int b)
{
    if(a!=0)
    {
        double x = -b/a;
        cout<<x<<endl;


    }
    else
    {
        cout<<"a = 0"<<endl;
    }
}
void f39(double a, double b, double c)
{
    double d = get_discriminant(a, b, c);
    if(d<0)
    {
        cout<<"error"<<endl;
    }
    double x1 = -b + sqrt(d)/a* 2;
    double x2 = -b - sqrt(d)/a* 2;
    cout<<x1<<" "<<x2<<endl;
}
void f40(double a1, double b1, double c1, double a2, double b2, double c2)
{
    double D = get_D(a1, a2, b1, b2);
    double x = (c1*b2 - c2*b1)/ D;
    double y = (a1*c2 - a2*c1)/ D;
    cout<<x<<" "<<y<<endl;
}
void f41(int l)
{
    double l1 = l/100;
    cout<<l1<<endl;

}
void f42(int m)
{
    double m1 = m/1000;
    cout<<m1<<endl;
}
void f43(int a)
{
    double a1 = a/1024;
    cout<<a1<<endl;
}
void f44(int a, int b)
{
    if(a<b)
    {
        cout<<"error"<<endl;
    }
    double c = a/b;
    cout<<c<<endl;
}
void f45(int a, int b)
{
    if(a<b)
    {
        cout<<"error"<<endl;
    }
    double c = a/b;
    double d = c* b;
    double n = a - d;
    cout<<n<<endl;

}
void f46(int a)
{
    int a1 = a/10;
    int a2 = a%10;
    cout << a1 << " " << a2 << endl;
}
void f47(int a)
{
    int a1 = a/10;
    int a2 = a%10;
    int sum = a1 + a2;
    int mul = a1 * a2;
    cout << sum << " " << mul << endl;
}
void f48(int a)
{
    int temp = 0;
    while(a)
    {
        temp *= 10;
        temp += a%10;
        a /= 10;
    }
    cout << temp << endl;
}
void f49(int a)
{
    int temp = a/100;
    cout << temp << endl;
}
void f50(int a)
{
    int a1 = a%100;
    a1 = a1/10;
    int a2 = a%10;
    cout << a1 << " " << a2 << endl;
}
void f51(int a)
{
    int a1 = a%10;
    int a2 = a/10;
    a2 = a2 %10;
    int a3 = a/100;
    a3 = a3%10;
    int sum = a1 + a2 + a3;
    int mul = a1 * a2 * a3;
    cout << sum << " " << mul << endl;

}
void f52(int a)
{
    int temp = 0;
    while(a)
    {
        temp *= 10;
        temp += a%10;
        a /= 10;
    }
    cout << temp << endl;
}
void f53(int a)
{
    int a1 = a/100;
    a1 = a1 %10;
    int a2 = a %100;
    a2 = a2 * 10;
    int new_a = a1 + a2;
    cout << new_a << endl;
}
void f54(int a)
{
    int a1 = a%10;
    a1 = a1*100;
    int a2 = a/10;
    int new_a = a1 + a2;
    cout << new_a << endl;
}
void f55(int a)
{
    int a1 = a/100;
    int a2 = a%100;
    a2 = a2 / 10;
    int a3 = a%10;
    int new_a = (a2 * 100) + (a1 * 10) + a3;
    cout << new_a << endl;
}
void f56(int a)
{
    int a1 = a/100;
    int a2 = a%100;
    a2 = a2 / 10;
    int a3 = a%10;
    int new_a = (a1 * 100) + (a3 * 10) + a2;
    cout << new_a << endl;
}
void f57(int a)
{
    if(a < 999)
    {
        cout << " digit < 999" << endl;
    }
    else
    {
    int new_a = a/100;
    new_a = new_a %10;
    cout << new_a << endl;
    }
}
void f58(int a)
{
    if(a < 999)
    {
        cout << "digit < 999" << endl;
    }
    else
    {
        int new_a = a/1000;
        new_a = new_a%10;
        cout << new_a << endl;
    }
}
void f59(int a)
{
    int minut = a/60;
    cout << minut << endl;
}
void f60(int a)
{
    int minut = a/60;
    int hour = minut/60;
    cout << hour << endl;
}
void f61(int a)
{
    a = a + 60;
    cout << a << endl;
}
void f62(int a)
{
    a = a + 3600;
    cout << a << endl;
}
void f63(int a)
{
    a = a + 3600;
    int minut = a / 60;
    cout << minut << endl;
}
void f64(int a)
{
    a = a%7;
    cout << a << endl;
}
void f65(int a)
{
    a = a + 4;
    a = a % 7;
    cout << a << endl;
}
void f66(int a)
{
    if(a%7==0)
    {
        a = 7;
        cout << a << endl;
    }
    else
    {
       a = a%7;
       cout << a << endl;
    }
}
void f67(int a)
{
    a = a + 5;
    if(a%7==0)
    {
        a = 7;
        cout << a << endl;
    }
    else
    {
        a = a % 7;
        cout << a << endl;
    }
}
void f68(int a, int b)
{
    cout << a + b << endl;
}
void f69()
{

}
void f70(int a)
{
    if(a < 0)
    {
        cout << "error " << endl;
    }
    else
    {
        int century = (a/100) + 1;
        cout << century << endl;
    }

}
bool f71(int a)
{
    return a > 0;
}
bool f72(int a)
{
    return a%2!=0;
}
bool f73(int a)
{
    return a%2==0;
}
bool f74(int a, int b)
{
    return a > 2 && b <= 3;
}
bool f75(int a, int b)
{
    return a >= 0 && b < -2;
}
bool f76(int a, int b, int c)
{
    return (a < b) && (b < c);
}
bool f77(int a, int b, int c)
{
    return (b < a) && (b > c);
}
bool f78(int a, int b)
{
    return a && b%2 != 0;
}
bool f79(int a, int b)
{
    return a%2 != 0 || b%2 !=0;
}
bool f80(int a, int b)
{
    return (a%2!=0) ^ (b%2!=0);
}
bool f81(int a, int b)
{
    return (a%2==0) == (b%2==0);
}
bool f82(int a, int b, int c)
{
    return a>0 && b> 0 && c>0;
}
bool f83(int a, int b, int c)
{
    return a > 0 || b > 0 || c > 0;
}
bool f84(int a, int b, int c)
{
    return (a > 0) ^ (b > 0) ^ (c > 0);
}
bool f85(int a, int b, int c)
{
   return (a > 0) !=  (b > 0) == (c > 0);
}
bool f86(int a)
{
    return a%2==0;
}
bool f87(int a)
{
    return a%2!=0;
}
bool f88(int a, int b, int c)
{
    return (a==b) || (b==c) || (c==a);
}
bool f89(int a, int b, int c)
{
    return (a!=b) || (b!=c) || (c!=a);
}
bool f90(int a)
{
    int a1 = a%10;
    int a2 = a%100;
    a2 = a2 / 10;
    int a3 = a%1000;
    a3 = a3 / 100;
    return (a1 == a2) && (a2 == a3);
}
bool f91(int a)
{
    int a1 = a%10;
    int a2 = a%100;
    a2 = a2 / 10;
    int a3 = a%1000;
    a3 = a3 / 100;
    return (a3 < a2) && (a2 < a1);
}
bool f92(int a)
{
    int a1 = a%10;
    int a2 = a%100;
    a2 = a2 / 10;
    int a3 = a%1000;
    a3 = a3 / 100;
    return ((a3 < a2) && (a2 < a1)) || ((a3 > a2) && (a2 > a1));
}
bool f93(int a)
{
    return a == reverse_(a);
}
bool f94(int a, int b, int c)
{
    double d = get_discriminant(a, b, c);
    if(d<0)
    {
        cout<<"error"<<endl;
    }
    double x1 = -b + sqrt(d)/a* 2;
    double x2 = -b - sqrt(d)/a* 2;
    if(x1 && x2/10 != 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool f95(int x, int y)
{
    if(x < 0 && y > 0)
    {
        return true;
    }
    return false;
}
bool f96(int x, int y)
{
    if(x > 0 && y < 0)
    {
        return true;
    }
    return false;
}
bool f97(int x, int y)
{
    if((x < 0 && y > 0) || (x < 0 && y < 0))
    {
        return true;
    }
    return false;
}
bool f98(int x, int y)
{
    if((x > 0 && y > 0) || (x < 0 && y < 0))
    {
        return true;
    }
    return false;
}
bool f99(int x, int x1, int x2, int y, int y1, int y2)
{
    return middle_point(x,x1,x2) && middle_point(y, y1, y2);
}
bool f100(int a, int b, int c)
{
    return (a == b) && (b == c);
}
int main()
{
    int array[5]{0};
    //f1(array, 5);
    //f2(array, 10);
    //f3(array, 5, 1, 2);
    //f4(array, 5, 1, 2);
    //f5(array, 10);
    //cout << f6(10) << endl;
    //cout << f7(10) << endl;
    //f8(3,4);
    //f9(5);
    //f10(3);
    //f11(2,3,4);
    //f12(3);
    //f13(4, 3);
    //f14(-5, -5);
    //f15(2, 3);
    //f16(5,3);
    //f17(4,3);
    //f18(4, 3);
    //f19(8);
    //f20(2);
    //f21(2,5);
    //f22(4, -4, 6);
    //f23(1, 9, 3);
    //f24(1,1,2,2);
    //f25(4,5);
    //f26(4,5,6);
    //f27(4,5,6);
    //f28(2);
    //f29(2);
    //f30(array, 3, 2);
    //f31(80);
    //f32(26.6667);
    //f33(3, 150, 10);
    //f34(2, 150, 4, 200);
    //f35(20, 5, 2, 3);
    //f36(80, 70, 50, 2);
    //f37(80, 70, 50 ,2);
    //f38(2, 4);
    //f39(1, 2, 1);
    //f40(2, 3, 12, 3, 2, 12);
    //f41(1000);
    //f42(1000);
    //f43(1024);
    //f44(5, 3);
    //f45(7, 3);
    //f46(25);
    //f47(25);
    //f48(25);
    //f49(321);
    //f50(456);
    //f51(123);
    //f52(123);
    //f53(983);
    //f54(123);
    //f55(123);
    //f56(123);
    //f57(1987);
    //f58(2789);
    //f59(100);
    //f60(8000);
    //f61(500);
    //f62(1000);
    //f63(60);
    //f64(1);
    //f65(68);
    //f66(1);
    //f67(1);
    //f68(3 , 4);
    //f69();
    //f70(1800);
    //cout << f71(3) << endl;
    //cout << f72(3) << endl;
    //cout << f73(4) << endl;
    //cout << f74(4,3) << endl;
    //cout << f75(3, -8) << endl;
    //cout << f76(2, 3, 5) << endl;
    //cout << f77(5, 3, 2) << endl;
    //cout << f78(3,5) << endl;
    //cout << f79(3, 6) << endl;
    //cout << f80(2, 5) << endl;
    //cout << f81(3,5) << endl;
    //cout << f82(4, 5, 6) << endl;
    //cout << f83(4,5,-3) << endl;
    //cout << f84(4, -4, -3) << endl;
    //cout << f85(-4, 4, 3) << endl;
    //cout << f86(26) << endl;
    //cout << f87(27) << endl;
    //cout << f88(3, 3, 5) << endl;
    //cout << f89(3,2,3) << endl;
    //cout << f90(333) << endl;
    //cout << f91(123) << endl;
    //cout << f92(123) << endl;
    //cout << f93(4554) << endl;
    //cout << f94(1, 2, 2) << endl;
    //cout << f95(-3, 5) << endl;
    //cout << f96(3, -5) << endl;
    //cout << f97(-3, -5) << endl;
    //cout << f98(-3,-4) << endl;
    //cout << f99(2,3,1, 5, 8, 2) << endl;
    cout << f100(4,4,4) << endl;
    cout << " " << endl;
    return 0;
}
