#include "MyClasses.h"

Figures::Figures(int* x1, int* y1)
{
    for (int i = 0; i < 4; i++)
    {
        x[i] = x1[i];
        y[i] = y1[i];
    }
}
Figures::~Figures() {
    delete[] this->x;
    delete[] this->y;
}

int Figures::length_of_side(int index1, int index2)
{
    index1--;
    index2--;
    if (x[index1] == x[index2]) return abs(y[index1] - y[index2]);
    else if (y[index1] == y[index2]) return abs(x[index1] - x[index2]);
    else return 0;
}

int Rectangles::Square()
{
    return this->length_of_side(1, 2) * this->length_of_side(2, 3);
}
int Rectangles::Perimeter()
{
    return (this->length_of_side(1, 2) + this->length_of_side(2, 3)) * 2;
}
int** Rectangles::Get_Info()
{
    int** coords = new int* [2];
    for (int i = 0; i < 2; i++) {
        coords[i] = new int[4];
    }
    for (int i = 0; i < 4; i++) {
        coords[0][i] = x[i];
    }
    for (int i = 0; i < 4; i++) {
        coords[1][i] = y[i];
    }
    return coords;
}