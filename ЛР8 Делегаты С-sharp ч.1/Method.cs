using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР8_Делегаты_С_sharp_ч._1
{
        public delegate bool MethodHandler();
        class Method
        {
            private string str;
            static public string str_static = "abc";
            public Method(string str1) { str = str1; }
            public bool ContainsLetters()
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLetter(str[i])) return true;
                }
                return false;
            }
            static public bool ContainsLetters_static()
            {
                for (int i = 0; i < str_static.Length; i++)
                {
                    if (char.IsLetter(str_static[i])) return true;
                }
                return false;
            }
        }
}
