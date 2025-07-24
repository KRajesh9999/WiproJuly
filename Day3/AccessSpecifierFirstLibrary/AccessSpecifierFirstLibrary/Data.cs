using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierFirstLibrary
{
    internal class Data : Demo
    {
        public void Hello()
        {
            Data data = new Data();
            Console.WriteLine(data.internalStr);
            Console.WriteLine(data.ipStr);
            Console.WriteLine(data.protectedStr);
            Console.WriteLine(data.publicStr);
        }
    }
}
