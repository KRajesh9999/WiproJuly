using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class NullableEx2
    {
        static void Main()
        {
            int? count = null;
            Console.WriteLine("Default value " + count.GetValueOrDefault());

            count = 5;
            Console.WriteLine("Updated value " + count.GetValueOrDefault()); 
        }
    }
}
