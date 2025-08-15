using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionConcept
{
    internal class ReflectionEx4_Depricated
    {
        [Obsolete("Depricated Method", false)]
        public static void TestMethod()
        {
            Console.WriteLine("Demo MEthod..."); 
        }
        static void Main()
        {

        }
    }
}
