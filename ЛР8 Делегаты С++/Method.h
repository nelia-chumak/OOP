#pragma once
#include <iostream>
#include <string>
using namespace std;
class Method
{
private: string str;
public:
    Method(string str1) { str = str1; }
    bool ContainsLetters()
    {
        for (int i = 0; i < this->str.length(); i++)
        {
            if (isalpha(this->str[i])) return true;
        }
        return false;
    }
};

