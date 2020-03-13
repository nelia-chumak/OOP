using System;

namespace ЛР2_Мой_класс_текст_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Text_library.MyStringClass str1 = new Text_library.MyStringClass("Hello World my");
            Text_library.MyContainerClass t = new Text_library.MyContainerClass();
            t.add_string("live", 0);
            t.Print();
            Console.WriteLine();
            t.add_string("love", 1);
            t.add_string("KPI", 2);
            Console.WriteLine("/");
            t.Print();
            Console.WriteLine("/");
            Console.WriteLine();
            t.delete_string(1);
            Console.WriteLine("//");
            t.Print();
            Console.WriteLine("//");
            Console.WriteLine();
            Text_library.MyStringClass s;
            s = t.smallest();
            s.Print();
            Console.WriteLine();
            s = t.acro();
            s.Print();
            Console.WriteLine();
            float x = t.frequence('l');
            Console.WriteLine(x);
            Console.WriteLine();
            Console.WriteLine();
            t.cleaner();
            Console.WriteLine("///");
            t.Print();
            Console.WriteLine("///");
            Console.WriteLine();
        }
    }
}
