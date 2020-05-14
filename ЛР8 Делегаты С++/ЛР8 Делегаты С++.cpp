#include "Method.h"
bool Call(Method& m, bool (Method::* fun)())
{
    return (m.*fun)();
}
int main()
{
    Method s("12fjh3");
    bool f = true;
    f = Call(s, &Method::ContainsLetters);
}
