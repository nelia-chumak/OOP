using System;

namespace ЛР8_Делегаты_С_sharp_ч._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Method s = new Method("123");
            MethodHandler d = s.ContainsLetters;
            MethodHandler d_static = Method.ContainsLetters_static;
            bool f = true;
            if (d != null) f = d();
            if (d_static != null) f = d_static();
        }
    }
}
