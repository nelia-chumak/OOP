using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР6_Исключения_С_sharp
{
    class Expression
    {
        private float a, b, c, d;

        public Expression()
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
        }
        public Expression(float a1, float b1, float c1, float d1)
        {
            a = a1;
            b = b1;
            c = c1;
            d = d1;
        }
        public Expression(Expression other)
        {
            this.a = other.a;
            this.b = other.b;
            this.c = other.c;
            this.d = other.d;
        }

        public double CalculateExpression()
        {
            if (41 - d < 0) throw new ArithmeticException("Negative value under square root");
            if ((Math.Sqrt(41 - d) - b * a + c) == 0) throw new DivideByZeroException("Division by 0");
            return (a * b / 4 - 1) / (Math.Sqrt(41 - d) - b * a + c);
        }
        public void SetValue(char ch, float value)
        {
            switch (ch)
            {
                case 'a': { a = value; break; }
                case 'b': { b = value; break; }
                case 'c': { c = value; break; }
                case 'd': { d = value; break; }
                default: break;
            }
        }
        public float GetValue(char ch)
        {
            switch (ch)
            {
                case 'a': return a;
                case 'b': return b;
                case 'c': return c;
                case 'd': return d;
                default: return 0;
            }
        }
    }
}
