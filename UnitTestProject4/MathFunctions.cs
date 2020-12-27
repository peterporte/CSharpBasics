using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math = System.Math;

namespace Section9
{
    class MathFunctions
    {
        public static double SquareRoot(double num1)
        {
            return Math.Sqrt(num1);
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        public static decimal Sum(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
}
