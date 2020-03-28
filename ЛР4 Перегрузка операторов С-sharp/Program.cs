using System;

namespace ЛР4_Перегрузка_операторов_С_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStringClass R1 = new MyStringClass();
            MyStringClass R2 = new MyStringClass("HELLO WORLD");
            R1 = R2;
            MyStringClass R3 = new MyStringClass(R1);
            R1.Print();
            R2.Print();
            R3.Print();
            Console.WriteLine();
            R2 = R2 / 2;
            R1.Print();
            R2.Print();
            R3.Print();
            Console.WriteLine();
            R1 = R2 + R3;
            R1.Print();
            R2.Print();
            R3.Print();
            Console.WriteLine();
        }
    }
}
