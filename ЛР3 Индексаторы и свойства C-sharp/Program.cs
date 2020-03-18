using System;

namespace ЛР3_Индексаторы_и_свойства_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 array = new Class1(1, 2, 3);
            for (int i = 0; i <= array.rows; i++)
            {
                for (int j = 0; j <= array.cols; j++)
                {
                    array[i, j] = i * array.cols + j + 1;
                }
            }
            array.Print();
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array.Mult);
        }
    }
}
