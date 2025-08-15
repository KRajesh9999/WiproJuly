using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class StrEx
    {
        static void Main()
        {
            string str = "Hello ";
            Console.WriteLine(string.Concat(str, "World"));

            Console.WriteLine(str);
            
        }
    }
}
