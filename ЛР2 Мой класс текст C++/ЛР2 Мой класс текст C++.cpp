#pragma comment(lib, "Text_static_library.lib")
#include "MyStringClass.h"
using namespace std;

int main()
{
    setlocale(LC_ALL, "RUS");
    MyStringClass str("Hello World my");
    MyContainerClass t;
    t.text[0] = "live";
    cout << endl;
    t.Print();
    cout << endl;
    MyContainerClass t1;
    t.add_string("love", 1);
    t.add_string("KPI", 2);
    cout << "/" << endl;
    t.Print();
    cout << "/" << endl;
    cout << endl;
    t.delete_string(2);
    cout << "//" << endl;
    t.Print();
    cout << "//" << endl;
    cout << endl;
    MyStringClass s;
    s = t.smallest();
    cout << s;
    cout << endl;
    s = t.acro();
    cout << s;
    cout << endl;
    float x = t.frequence('l');
    cout << x;
    cout << endl << endl;
    t.cleaner();
    cout << "///" << endl;
    t.Print();
    cout << "///" << endl;
    cout << endl;

    return 0;
}