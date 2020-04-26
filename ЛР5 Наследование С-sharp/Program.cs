using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new[] { 0, 0, 2, 2 };
            int[] y = new[] { 0, 1, 1, 0 };
            Figures f1 = new Figures(x, y);
            int l = f1.length_of_side(1, 2);
            Rectangles r1 = new Rectangles(x, y);
            int s = r1.Square();
            int p = r1.Perimeter();
            int[] x1 = new int[4];
            int[] y1 = new int[4];
            (x1, y1) = r1.Get_Info();
        }
    }
}
