using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal static class ExtendedMultiplicationOperation
    {
        public static int Mult(this Calculation calc, int a, int b)
        {
            return a * b;
        }
    }
}
