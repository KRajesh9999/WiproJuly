using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassEx2
{
    internal class Demo : IOne, ITwo
    {
        public void Email()
        {
            Console.WriteLine("Email is wipro@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Name is Prasanna...");
        }
    }
}
