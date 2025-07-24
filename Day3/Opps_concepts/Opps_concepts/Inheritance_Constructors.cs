using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_concepts
{
    internal class Inheritance_Constructors
    {
        class C1
        {
            public C1()
            {
                Console.WriteLine("Base class constructor");
            }

        }
        class C2 : C1
        {
            public C2()
            {
                Console.WriteLine("Derived class constructor...");
                
            }
        }
        static void Main(string[] args)
        {
            C2 c2 = new C2();// just created one object for Base class
        }
    }
}
