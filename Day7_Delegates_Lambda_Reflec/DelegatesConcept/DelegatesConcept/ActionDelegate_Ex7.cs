using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConcept
{
    internal class ActionDelegate_Ex7
    {
        public delegate void MyDelegate(string str);

        public static void Greeting(string s)
        {
            Console.WriteLine("Good Morning " + s);
        }

        static void Main()
        {
            MyDelegate obj = Greeting;
            obj("Rajesh");
        }
    }
}
