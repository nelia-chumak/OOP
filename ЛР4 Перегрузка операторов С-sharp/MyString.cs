using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР4_Перегрузка_операторов_С_sharp
{
    class MyStringClass
    {
        private char[] str;

        public MyStringClass()
        {
            str = null;
        }
        public MyStringClass(string str)
        {
            int len = str.Length;
            char[] newChar = new char[len + 1];
            for (int j = 0; j < len; j++)
                newChar[j] = str[j];
            newChar[len] = '\0';
            this.str = newChar;
        }
        public MyStringClass(char[] str)
        {
            int len = str.Length;
            char[] newChar = new char[len + 1];
            for (int j = 0; j < len; j++)
                newChar[j] = str[j];
            newChar[len] = '\0';
            this.str = newChar;
        }
        public MyStringClass(MyStringClass value)
        {
            int len = strlength(value.str);
            this.str = new char[len + 1];
            for (int i = 0; i < len; i++)
                this.str[i] = value.str[i];
            this.str[len] = '\0';
        }

        public static int strlength(char[] str)
        {
            int len = 0;
            int i = 0;
            while (str[i] != '\0')
            {
                len++;
                i++;
            }
            return len;
        }
        public int Length(MyStringClass strin)
        {
            return strlength(strin.str);
        }

        public int Length()
        {
            return strlength(this.str);
        }

        char[] get_value(MyStringClass strin)
        {
            return strin.str;
        }

        char[] get_value()
        {
            return this.str;
        }


        public void Print()
        {
            Console.WriteLine(this.str);
        }


        public static MyStringClass operator +(MyStringClass thiss, MyStringClass other)
        {
            MyStringClass newString = new MyStringClass();
            int len = strlength(thiss.str);
            newString.str = new char[strlength(thiss.str) + strlength(other.str) + 1];
            int i;
            for (i = 0; i < strlength(thiss.str); i++)
                newString.str[i] = thiss.str[i];
            for (int j = 0; j < strlength(other.str); j++, i++)
                newString.str[i] = other.str[j];
            newString.str[strlength(thiss.str) + strlength(other.str)] = '\0';
            return newString;
        }
        public static MyStringClass operator /(MyStringClass thiss, int num)
        {
            MyStringClass newString = new MyStringClass();
            int len = strlength(thiss.str);
            len = len % num == 0 ? len / num : len / num + 1;
            newString.str = new char[len + 1];
            for (int i = 0, j = 0; i < strlength(thiss.str); i++)
            {
                if (i % num == 0)
                {
                    newString.str[j] = thiss.str[i];
                    j++;
                }
            }
            newString.str[len] = '\0';
            return newString;
        }
    }
}
