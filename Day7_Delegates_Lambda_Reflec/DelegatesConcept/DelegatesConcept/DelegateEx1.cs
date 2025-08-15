using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConcept
{
    internal class DelegateEx1
    {
        public delegate void MyDelegate();

        public static void Show()
        {
            Console.WriteLine("Welcome to Delegates..");
        }
        static void Main(string[] args)
        {
            MyDelegate obj = new MyDelegate(Show);
            obj();
        }
    }
}
