using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class BitWise
    {
        static void Main()
        {
            int a = 5, b = 3; // 101 & 011 = 001
            Console.WriteLine("BitWise Operations: ");
            Console.WriteLine("AND Operator result: "+(a & b)); // AND operator
            Console.WriteLine("OR operator result: "+(a | b)); // OR operator
            Console.WriteLine("NOT operator result: " + (~a)); // NOT operator
            Console.WriteLine("EX-OR operator result: " + (a ^ b)); // EX-OR operator

        }
    }
}
