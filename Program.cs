using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Polynomials.Polynomials;

namespace Polynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            Part[] polynomial = {new Part(5, 2), new Part(3, 1), new Part(5, 0)};
            Console.WriteLine(Subsitute(polynomial, 2));
            Console.WriteLine(polynomial[0].ToString());
            Console.ReadKey();
        }
    }
}
