using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_concepts
{
    internal class OverloadEx
    {
        public void Show(int x)
        {
            Console.WriteLine("Show method w.r.t int "+x);
        }

        public void Show(double x)
        {
            Console.WriteLine("Show method w.r.t Double "+x);
        }

        public void Show(String x)
        {
            Console.WriteLine("Show method w.r.t String " + x) ;
        }
        static void Main()
        {
            OverloadEx obj = new OverloadEx();
            obj.Show(12);
            obj.Show("wipro");
            obj.Show(534.45);
        }
    }
}
