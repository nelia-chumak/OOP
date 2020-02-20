using System;

namespace ЛР1_Побитовые_операции_С_sharp
{
    class Program
    {
        public static int amount(int x, int y)
        {
            int sum = 0;
            int temp = 1;
            int up = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((((x & temp) == temp && (y & temp) != temp) || ((x & temp) != temp && (y & temp) == temp)) && up == 0)
                {
                    sum = sum | (1 << i);
                }
                if ((x & temp) == temp && (y & temp) == temp)
                {
                    if (up == 0) up = 1;
                    else sum = sum | (1 << i);
                }
                if ((x & temp) != temp && (y & temp) != temp && up == 1)
                {
                    up = 0;
                    sum = sum | (1 << i);
                }
                temp = temp << 1;
            }
            return sum;
        }

        public static void dec(ref int x)
        {
            int z = x;
            int i = 0;
            bool f = true;
            while (f)
            {
                x = x ^ (1 << i);
                if ((z & (1 << i)) != 0) f = false;
                i++;
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = rnd.Next(-5, 5);
            int y = rnd.Next(-5, 5);
            int sum = amount(x, y);
            dec(ref x);
        }
    }
}
