using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Jagged_Arr_Parameter_Types
{
    internal class Str_GetHashCode
    {
        static void Main()
        {
            string s1 = "Rajesh", s2 = "Ramesh", s3 = "Rakesh", s4 = "Rithish";
            Console.WriteLine("S1 address: "+s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s4.GetHashCode());
        }
    }
}
