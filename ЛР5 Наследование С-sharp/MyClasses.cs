using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Figures
    {
        protected int[] x = new int[4];
        protected int[] y = new int[4];

        public Figures(int[] x1, int[] y1)
        {
            for (int i = 0; i < 4; i++)
            {
                x[i] = x1[i];
                y[i] = y1[i];
            }
        }

        public int length_of_side(int index1, int index2)
        {
            index1--;
            index2--;
            if (x[index1] == x[index2]) return Math.Abs(y[index1] - y[index2]);
            else if (y[index1] == y[index2]) return Math.Abs(x[index1] - x[index2]);
            else return 0;
        }
    }

    class Rectangles : Figures
    {
        public Rectangles(int[] x1, int[] y1) : base(x1, y1) { }

        public int Square()
        {
            return this.length_of_side(1, 2) * this.length_of_side(2, 3);
        }
        public int Perimeter()
        {
            return (this.length_of_side(1, 2) + this.length_of_side(2, 3)) * 2;
        }
        public (int[] x, int[] y) Get_Info()
        {
            return (x, y);
        }
    }
}
