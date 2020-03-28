#include "MyString.h"
using namespace std;

MyStringClass::MyStringClass() {
    str = nullptr;
}

MyStringClass::MyStringClass(const char* string) {
    int len = strlength(string);
    this->str = new char[len + 1];
    for (int i = 0; i < len; i++)
        this->str[i] = string[i];
    this->str[len] = '\0';
}

MyStringClass::MyStringClass(const MyStringClass& value) {
    int len = strlength(value.str);
    this->str = new char[len + 1];
    for (int i = 0; i < len; i++)
        this->str[i] = value.str[i];
    this->str[len] = '\0';
}

MyStringClass::~MyStringClass() {
    delete[] this->str;
}



int MyStringClass::strlength(const char* str) {
    int len = 0;
    while (*str) {
        len++;
        str++;
    }
    return len;
}

int MyStringClass::Length(MyStringClass string) {
    return strlength(string.str);
}

int MyStringClass::Length() {
    return strlength(this->str);
}

char* MyStringClass::get_value(MyStringClass string) {
    return string.str;
}

char* MyStringClass::get_value() {
    return this->str;
}



MyStringClass& MyStringClass::operator =(const MyStringClass& other) {
    if (this != nullptr) delete[] str;
    int len = strlength(other.str);
    this->str = new char[len + 1];
    for (int i = 0; i < len; i++)
        this->str[i] = other.str[i];
    this->str[len] = '\0';
    return *this;
}

MyStringClass MyStringClass::operator+(const MyStringClass& other) {
    MyStringClass newString;
    newString.str = new char[strlength(this->str) + strlength(other.str) + 1];
    int i;
    for (i = 0; i < strlength(this->str); i++)
        newString.str[i] = this->str[i];
    for (int j = 0; j < strlength(other.str); j++, i++)
        newString.str[i] = other.str[j];
    newString.str[strlength(this->str) + strlength(other.str)] = '\0';
    return newString;
}

MyStringClass MyStringClass::operator/(int num) {
    MyStringClass newString;
    int len = strlength(this->str);
    len = len % num == 0 ? len / num : len / num + 1;
    newString.str = new char[len + 1];
    for (int i = 0, j = 0; i < strlength(this->str); i++)
        if (i % num == 0) {
            newString.str[j] = this->str[i];
            j++;
        }
    newString.str[len] = '\0';
    return newString;
}

std::ostream& operator <<(std::ostream& out, const MyStringClass& other)
{
    return out << other.str;
}