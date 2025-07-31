using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_WithOut_LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            First obj = new Second();
            obj.Show();
        }
    }
}
