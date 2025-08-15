using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_concepts
{
    internal class ConstructorEx
    {
        static ConstructorEx() //automatically invokes without any class instance
        {
            Console.WriteLine("Static Constructor...");
        }
        ConstructorEx()  // once obj created it invokes
        {
            Console.WriteLine("Instance Constructor...");
        }
        static void Main()
        {
            ConstructorEx obj = new ConstructorEx();
        }
    }
}
