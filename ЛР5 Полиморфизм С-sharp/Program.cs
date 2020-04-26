using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Characters c = new Characters("gvh23#$%#");
            int l1 = c.str_len();
            c.char_replace();
            l1 = c.str_len();
            Numbers n = new Numbers("gvh23#$%#");
            int l2 = n.str_len();
            n.char_replace();
            l2 = n.str_len();
        }
    }
}
