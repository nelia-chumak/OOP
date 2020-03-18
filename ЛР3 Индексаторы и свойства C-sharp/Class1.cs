using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР3_Индексаторы_и_свойства_C_sharp
{
    public class Class1
    {
        public static int row, col;
        public int rows, cols;
        public int start;
        public bool error;
        private int[,] arr = new int[row, col];
        private int mult;

        public Class1(int s, int r, int c)
        {
            start = s;
            arr = new int[r, c];
            row = r;
            col = c;
            error = false;
            rows = r;
            cols = c;
        }
        public float this[int index]
        {
            get
            {
                index = index - start;
                if (index >= 0 && index < cols * rows)
                {
                    error = false;
                    float sum = 0;
                    for (int i = 0; i < cols; i++)
                    {
                        sum += arr[index, i];
                    }
                    return sum / cols;
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
        }
        public int this[int index1, int index2]
        {
            set
            {
                if (index1 >= 0 && index1 < rows && index2 >= 0 && index2 < cols)
                {
                    error = false;
                    arr[index1, index2] = value;
                }
                else
                {
                    error = true;
                }
            }
            get
            {
                if (index1 >= 0 && index1 < rows && index2 >= 0 && index2 < cols)
                {
                    error = false;
                    return arr[index1, index2];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
        }
        public int Mult
        {
            get
            {
                mult = 1;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        mult *= arr[i, j];
                    }
                }
                return mult;
            }
        }
        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
