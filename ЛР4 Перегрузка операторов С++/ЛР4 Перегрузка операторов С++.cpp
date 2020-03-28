#include "MyString.h"
using namespace std;

int main()
{
    MyStringClass R1;
    MyStringClass R2("HELLO WORLD");
    R1 = R2;
    MyStringClass R3(R1);
    cout << R1 << endl << R2 << endl << R3 << endl << endl;
    R2 = R2 / 2;
    cout << R1 << endl << R2 << endl << R3 << endl << endl;
    R1 = R2 + R3;
    cout << R1 << endl << R2 << endl << R3 << endl << endl;
    return 0;
}