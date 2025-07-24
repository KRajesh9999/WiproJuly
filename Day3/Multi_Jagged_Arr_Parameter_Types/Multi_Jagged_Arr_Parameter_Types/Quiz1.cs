using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Jagged_Arr_Parameter_Types
{
    internal class Quiz1
    {
        public void Increment(ref int x)
        {
            x++;
        }
        static void Main()
        {
            int x = 12;
            Quiz1 quiz1 = new Quiz1();
            quiz1.Increment(ref x);
            Console.WriteLine(x);
        }
    }
}
