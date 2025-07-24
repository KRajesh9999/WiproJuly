using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Var_Method_NonStatic
{
    internal class Static_Cricket
    {
        static int score;
        public void Increment(int x)
        {
            score += x;
        }
        
        static void Main()
        {
            Static_Cricket fb = new Static_Cricket();
            Static_Cricket sb = new Static_Cricket();
            Static_Cricket ext = new Static_Cricket();

            fb.Increment(14);
            sb.Increment(9);
            ext.Increment(14);

            Console.WriteLine("Total Score " + Static_Cricket.score); ;
        }
    }
}
