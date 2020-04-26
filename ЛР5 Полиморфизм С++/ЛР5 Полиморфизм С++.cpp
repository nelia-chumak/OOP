#include "MyClasses.h"
using namespace std;

int main()
{
    Characters c("gvh23#$%#");
    int l1 = c.str_len();
    c.char_replace();
    l1 = c.str_len();
    Numbers n("gvh23#$%#");
    int l2 = n.str_len();
    n.char_replace();
    l2 = n.str_len();
}