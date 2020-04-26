#include "MyClasses.h"
using namespace std;

int main()
{
    int* x = new int[4];
    x[0] = 0;
    x[1] = 0;
    x[2] = 2;
    x[3] = 2;
    int* y = new int[4];
    y[0] = 0;
    y[1] = 1;
    y[2] = 1;
    y[3] = 0;
    Figures f1(x, y);
    int l = f1.length_of_side(1, 2);
    Rectangles r1(x, y);
    int s = r1.Square();
    int p = r1.Perimeter();
    int** coords = new int* [2];
    for (int i = 0; i < 2; i++) {
        coords[i] = new int[4];
    }
    coords = r1.Get_Info();
}