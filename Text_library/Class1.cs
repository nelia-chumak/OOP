using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_library
{
    public class MyStringClass
    {
        public char[] str;
        public int len;
        public int strlength(char[] str)
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

        MyStringClass()
        {
            str = null;
            len = 0;
        }
        //для передачи строки при создании объекта класса
        public MyStringClass(string str)
        {
            len = str.Length;
            char[] newChar = new char[len + 1];
            for (int j = 0; j < len; j++)
                newChar[j] = str[j];
            newChar[len] = '\0';
            this.str = newChar;
        }
        //для передачи строки при создании объекта класса
        public MyStringClass(char[] str)
        {
            len = str.Length;
            char[] newChar = new char[len + 1];
            for (int j = 0; j < len; j++)
                newChar[j] = str[j];
            newChar[len] = '\0';
            this.str = newChar;
        }
        //для копирования в другую область памяти
        public MyStringClass(ref MyStringClass value)
        {
            len = strlength(value.str);
            this.str = new char[len + 1];
            for (int i = 0; i < len; i++)
                this.str[i] = value.str[i];
            this.str[len] = '\0';
        }
        public void Print()
        {
            Console.WriteLine(this.str);
        }
    }


    public class MyContainerClass
    {
        private MyStringClass[] text;
        private int clv_str = 0;

        public MyContainerClass()
        {
            this.clv_str = 0;
            this.text = null;
        }
        //для передачи строки при создании объекта класса
        public MyContainerClass(MyStringClass[] string1)
        {
            this.text = new MyStringClass[this.clv_str];
            for (int i = 0; i < this.clv_str; i++)
                this.text[i] = string1[i];
        }
        //для копирования в другую область памяти
        public MyContainerClass(ref MyContainerClass value)
        {
            this.text = new MyStringClass[this.clv_str];
            for (int i = 0; i < this.clv_str; i++)
                this.text[i] = value.text[i];
        }

        public MyContainerClass add_string(MyStringClass str1, int position)
        {
            this.clv_str++;
            var newContainer = new MyStringClass[this.clv_str];
            for (int i = 0; i < this.clv_str; i++)
            {
                if (i == position) newContainer[position] = str1;
                else if (i < position) newContainer[i] = this.text[i];
                else if (i > position) newContainer[i] = this.text[i - 1];
            }
            this.text = new MyStringClass[this.clv_str];
            for (int i = 0; i < this.clv_str; i++)
            {
                this.text[i] = newContainer[i];
            }
            return this;
        }
        public MyContainerClass add_string(string str1, int position)
        {
            this.clv_str++;
            MyStringClass newString = new MyStringClass(str1);
            var newContainer = new MyStringClass[this.clv_str];
            for (int i = 0; i < this.clv_str; i++)
            {
                if (i == position) newContainer[position] = newString;
                else if (i < position) newContainer[i] = this.text[i];
                else if (i > position) newContainer[i] = this.text[i - 1];
            }
            this.text = new MyStringClass[this.clv_str];
            for (int i = 0; i < this.clv_str; i++)
            {
                this.text[i] = newContainer[i];
            }
            return this;
        }
        public MyContainerClass delete_string(int position)
        {
            if (clv_str > 1)
            {
                var newContainer = new MyStringClass[this.clv_str - 1];
                for (int i = 0; i < this.clv_str - 1; i++)
                {
                    if (i < position) newContainer[i] = this.text[i];
                    else newContainer[i] = this.text[i + 1];
                }
                this.clv_str--;
                this.text = newContainer;
            }
            else
            {
                this.clv_str = 0;
                MyStringClass[] Text = new MyStringClass[0];
                text = Text;
            }
            return this;
        }
        public MyContainerClass cleaner()
        {
            MyStringClass[] Text = new MyStringClass[0];
            text = Text;
            clv_str = 0;
            return this;
        }
        public MyStringClass smallest()
        {
            MyStringClass newString = new MyStringClass("");
            if (clv_str > 0)
            {
                int min_len = 32000;
                for (int i = 0; i < this.clv_str; i++)
                {
                    if (text[i].len < min_len)
                    {
                        min_len = text[i].len;
                        newString = text[i];
                    }
                }
            }
            else
            {
                MyStringClass newString2 = new MyStringClass("no words");
                newString = newString2;
            }
            return newString;
        }
        public MyStringClass acro()
        {
            MyStringClass newString = new MyStringClass("");
            if (clv_str > 0)
            {
                newString.len = this.clv_str;
                newString.str = new char[this.clv_str];
                for (int i = 0; i < this.clv_str; i++)
                    newString.str[i] = text[i].str[0];
            }
            else
            {
                MyStringClass newString2 = new MyStringClass("no words");
                newString = newString2;
            }
            return newString;
        }
        public float frequence(char ch)
        {
            if (clv_str > 0)
            {
                float counter = 0,
                      sum = 0;
                for (int i = 0; i < this.clv_str; i++)
                {
                    for (int j = 0; j < text[i].len; j++)
                        if (text[i].str[j] == ch) counter++;
                    sum += text[i].len;
                }
                return counter / sum;
            }
            else return 0;
        }
        public void Print()
        {
            for (int i = 0; i < this.clv_str; i++)
            {
                Console.WriteLine(text[i].str);
            }
        }
    }
}
