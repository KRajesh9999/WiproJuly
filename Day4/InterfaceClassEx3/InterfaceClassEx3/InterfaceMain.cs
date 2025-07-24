using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace InterfaceClassEx3
{
    internal class InterfaceMain
    {
        static void Main(string[] args)
        {
            IOne obj1 = new Test();
            obj1.Show();

            ITwo obj2 = new Test();
            obj2.Show();
        }
    }
}
