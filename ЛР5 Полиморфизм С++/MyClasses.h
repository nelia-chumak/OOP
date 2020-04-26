#pragma once
#include <iostream>
#include <cmath>
#include <string>
using namespace std;

class String
{
public:
    virtual int str_len() { return 0; }
    virtual string char_replace() { return ""; }
};

class Characters : public String
{
private:
    string s;

public:
    int strlength(string);
    Characters(string);
    int str_len();
    string char_replace();
};

class Numbers : public String
{
private:
    string s;

public:
    int strlength(string);
    Numbers(string);
    int str_len();
    string char_replace();
};

