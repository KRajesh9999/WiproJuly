using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_WithOut_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JavaTrgInfo obj = new JavaTrgInfo(new JavaTrg());
            DotNetTrgInfo obj2 = new DotNetTrgInfo(new DotNetTrg());

            obj.Details();
            obj2.Details();
        }
    }
}
