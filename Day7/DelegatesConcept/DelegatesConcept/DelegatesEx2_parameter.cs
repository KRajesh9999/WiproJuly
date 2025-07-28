using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConcept
{
    internal class DelegatesEx2_parameter
    {
        public delegate void MyDelegate(string s);

        public static void Show(string s)
        {
            Console.WriteLine("Welcome to delegates from " + s);
        }
        static void Main()
        {
            MyDelegate obj = new MyDelegate(Show);
            obj("Rajesh");
        }
    }
}
