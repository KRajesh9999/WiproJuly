using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_concepts
{
    internal class OverloadEx2
    {
        public int Sum()
        {
            return 5;
        }

        public int Sum(int x)
        {
            return x + 5;
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main()
        {
            OverloadEx2 obj = new OverloadEx2();
            Console.WriteLine("Sum w.r.t zero Args: "+obj.Sum());
            Console.WriteLine("Sum w.r.t one Args: " + obj.Sum(54));
            Console.WriteLine("Sum w.r.t two Args: " + obj.Sum(45, 55));
        }
    }
}
