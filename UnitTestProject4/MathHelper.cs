using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    class MathHelper
    {
        public static int Static_Square(int nValue)
        {
            return nValue * nValue;
        }

        public static int AddNumber(int number1 = 5, int number2 = 10)
        {
            return number1 + number2;
        }
    }
}
