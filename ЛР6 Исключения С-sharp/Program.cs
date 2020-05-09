using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ЛР6_Исключения_С_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("Log_file.txt");
            DateTime thisDay = DateTime.Today;
            Expression[] o = new Expression[3];
            try
            {
                o[0] = new Expression(0, 3, 4, 40);
                o[1] = new Expression(1, 4, -2, 42);
                o[2] = new Expression();
                o[2].SetValue('a', -1);
                o[2].SetValue('b', 8);
                o[2].SetValue('c', -10);
                o[2].SetValue('d', 37);
                for (int i = 0; i < 4; i++)
                {
                    try { Console.WriteLine(o[i].CalculateExpression()); }
                    catch (DivideByZeroException exept)
                    {
                        using (TextWriter t = new StreamWriter("Log_file.txt", true, System.Text.Encoding.Default))
                        {
                            t.WriteLine(exept.Message);
                            t.WriteLine(thisDay.ToString("d"));
                        }
                    }
                    catch (ArithmeticException exept)
                    {
                        using (TextWriter t = new StreamWriter("Log_file.txt", true, System.Text.Encoding.Default))
                        {
                            t.WriteLine(exept.Message);
                            t.WriteLine(thisDay.ToString("d"));
                        }
                    }
                }
            }

            catch (IndexOutOfRangeException)
            {
                using (TextWriter t = new StreamWriter("Log_file.txt", true, System.Text.Encoding.Default))
                {
                    t.WriteLine("Matching item not found");
                    t.WriteLine(thisDay.ToString("d"));
                }
            }
            finally { Console.WriteLine("All items are processed. Program completed"); }
        }
    }
}
