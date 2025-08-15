using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_WithOut_LSP
{
    internal class Second : First
    {
        public new void Show()
        {
            Console.WriteLine("Show Method from Class Second...");
        }
    }
}
