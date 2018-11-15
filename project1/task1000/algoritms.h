#ifndef ALGORITMS_H_INCLUDED
#define ALGORITMS_H_INCLUDED
double S_of_x_y(int x1, int y1, int x2, int y2)
{
    double S = sqrt(pow(x2-x1,2)+pow(y2-y1,2));
    return S;
}
double p(int a, int b, int c)
{
    int h = (a+b+c)/2;
    return h;
}
double get_discriminant(double a, double b, double c)
{
    return pow(b,2)-4*a*c;
}
double get_D(double a1, double a2, double b1, double b2)
{
    double d = 0;
    return d = a1*b2 - a2*b1;
}
#endif // ALGORITMS_H_INCLUDED
