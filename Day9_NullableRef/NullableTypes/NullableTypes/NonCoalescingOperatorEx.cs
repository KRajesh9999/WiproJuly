using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class NonCoalescingOperatorEx
    {
        static void Main()
        {
            string s1 = null;
            string s2 = "Welcome";
            string s3 = "Bye";

            string s4 = s1 ?? s2;
            Console.WriteLine("Since s1 is Null, S2 is printing: "+ s4);

            s4 = s3 ?? s2;
            Console.WriteLine("Since s3 is Not Null, s2 is not printing: "+s4);
        }
    }
}
