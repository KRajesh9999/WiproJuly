using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConcept
{
    internal class DelegateEx6_AnonymsDelegate
    {
        public delegate void MyDelegate(string str);

        static void Main()
        {
            MyDelegate obj = delegate (string str)
            {
                Console.WriteLine("This is Anonymous method..." + str);
            };

            obj("Rajesh");
        }
    }
}
