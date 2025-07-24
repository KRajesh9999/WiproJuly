using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassEx1
{
    internal class Sunil : ITraining
    {
        public void Email()
        {
            Console.WriteLine("Email is sunil@gmailcom");
        }
        public void Name()
        {
            Console.WriteLine("Hi Name is Sunil...");
        }
    }
}
