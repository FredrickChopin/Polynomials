using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomials
{
    public static class Polynomials
    {
        public static double Subsitute(Part[] polynomial, double x)
        {
            double value = 0;
            foreach (Part part in polynomial)
            {
                value += part.Subsitute(x);
            }
            return value;
        }

        public static new string ToString(Part[] polynomial)
        {
            var strBuilder = new StringBuilder();
            for (int i=0; i<polynomial.Length-1; i++)
            {
                strBuilder.AppendFormat(polynomial[i].ToString());
                if (polynomial[i+1].a>0)
                {
                    strBuilder.Append("+");
                }
                else
                {
                    strBuilder.Append("-");
                }
            }
            strBuilder.Append(polynomial[polynomial.Length - 1]);
            return strBuilder.ToString();
        }
    }

    public class Part
    {
        
        //a is the coefficient מקדם
        //n is the exponent חזקה

        public Part(double a, double n)
        {
            this.a = a;
            this.n = n;
        }
        public double n
        {
            get; set;
        }
        public double a
        {
            get; set;
        }

        public double Subsitute(double x)
        {
            return a * Math.Pow(x, n);
        }

        public void Derive()
        {
            this.a = a * n;
            this.n -= 1;
        }

        public override string ToString()
        {
            if (n == 0)
            {
                return a;
            }
            else if (n == 1)
            {
                return string.Format(a + "X");
            }
            else
            {
                return string.Format(a + "X^" + n);
            }
        }

    }
}
