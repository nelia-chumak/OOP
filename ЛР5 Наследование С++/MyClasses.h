#pragma once
#include <iostream>
#include <cmath>

class Figures
{
protected:
    int* x = new int[4];
    int* y = new int[4];

public:
    Figures(int*, int*);
    ~Figures();

    int length_of_side(int, int);
};

class Rectangles : public Figures
{
public:
    Rectangles(int* x1, int* y1) : Figures(x1, y1) { };

    int Square();
    int Perimeter();
    int** Get_Info();
};

