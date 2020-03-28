#pragma once
#include <iostream>

class MyStringClass {
private:
    char* str;

public:
    MyStringClass();
    MyStringClass(const char*);
    MyStringClass(const MyStringClass&);
    ~MyStringClass();

    int strlength(const char*);
    int Length(MyStringClass string);
    int Length();
    char* get_value(MyStringClass string);
    char* get_value();

    MyStringClass& operator =(const MyStringClass&);
    MyStringClass operator+(const MyStringClass&);
    MyStringClass operator/(int num);

    friend std::ostream& operator <<(std::ostream&, const MyStringClass&);
};