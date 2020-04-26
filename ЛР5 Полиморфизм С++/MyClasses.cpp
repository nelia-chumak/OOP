#include "MyClasses.h"

int Characters::strlength(string str) {
    int len = 0;
    while (str[len] != '\0') {
        len++;
    }
    return len;
}
int Numbers::strlength(string str) {
    int len = 0;
    while (str[len] != '\0') {
        len++;
    }
    return len;
}


Characters::Characters(string s1)
{
    s = s1;
}

int Characters::str_len()
{
    return strlength(s);
}
string Characters::char_replace()
{
    int counter = 0;
    for (int i = 0; i < strlength(s); i++) { if (s[i] == '#') counter++; }
    string arr = s;
    for (int i = 0; i < counter; i++) arr += '1';
    for (int i = 0, j = 0; i < strlength(s); i++, j++)
    {
        if (s[i] != '#')  arr[j] = s[i];
        else
        {
            arr[j] = '!';
            arr[j + 1] = '!';
            j++;
        }
    }
    s = arr;
    return s;
}

Numbers::Numbers(string s1)
{
    int counter = 0;
    for (int i = 0; i < strlength(s1); i++) { if (isdigit(s1[i])) counter++; }
    string arr = "";
    for (int i = 0; i < counter; i++) arr += '1';
    for (int i = 0, j = 0; j < strlength(s1); i++, j++)
    {
        if (isdigit(s1[j])) arr[i] = s1[j];
        else i--;
    }
    s = arr;
}
int Numbers::str_len()
{
    return strlength(s);
}
string Numbers::char_replace()
{
    int counter = 0;
    for (int i = 0; i < strlength(s); i++) { if (s[i] == '3') counter++; }
    string arr = s;
    for (int i = 0; i < counter; i++) arr += '1';
    for (int i = 0, j = 0; i < strlength(s); i++, j++)
    {
        if (s[i] != '3')  arr[j] = s[i];
        else
        {
            arr[j] = '1';
            arr[j + 1] = '1';
            j++;
        }
    }
    s = arr;
    return s;
}