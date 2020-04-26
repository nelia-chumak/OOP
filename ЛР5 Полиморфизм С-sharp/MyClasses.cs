using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class String
    {
        virtual public int str_len() { return 0; }
        virtual public string char_replace() { return ""; }
    }

    class Characters : String
    {
        private string s;

        public Characters(string s1)
        {
            s = s1;
        }

        override public int str_len()
        {
            return s.Length;
        }
        override public string char_replace()
        {
            int counter = 0;
            for (int i = 0; i < s.Length; i++) { if (s[i] == '#') counter++; }
            char[] arr = new char[s.Length];
            Array.Resize(ref arr, s.Length + counter);
            for (int i = 0, j = 0; i < s.Length; i++, j++)
            {
                if (s[i] != '#') arr[j] = s[i];
                else
                {
                    arr[j] = '!';
                    arr[j + 1] = '!';
                    j++;
                }
            }
            s = new string(arr);
            return s;
        }
    }

    class Numbers : String
    {
        private string s;

        public Numbers(string s1)
        {
            int counter = 0;
            for (int i = 0; i < s1.Length; i++) { if (Char.IsDigit(s1[i])) counter++; }
            char[] arr = new char[counter];
            for (int i = 0, j = 0; j < s1.Length; i++, j++)
            {
                if (Char.IsDigit(s1[j])) arr[i] = s1[j];
                else i--;
            }
            s = new string(arr);
        }

        override public int str_len()
        {
            return s.Length;
        }
        override public string char_replace()
        {
            int counter = 0;
            for (int i = 0; i < s.Length; i++) { if (s[i] == '3') counter++; }
            char[] arr = new char[s.Length];
            Array.Resize(ref arr, s.Length + counter);
            for (int i = 0, j = 0; i < s.Length; i++, j++)
            {
                if (s[i] != '3') arr[j] = s[i];
                else
                {
                    arr[j] = '1';
                    arr[j + 1] = '1';
                    j++;
                }
            }
            s = new string(arr);
            return s;
        }
    }
}
