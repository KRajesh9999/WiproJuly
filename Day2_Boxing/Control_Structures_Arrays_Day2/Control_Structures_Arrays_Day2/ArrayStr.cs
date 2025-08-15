using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Structures_Arrays_Day2
{
    internal class ArrayStr
    {
        public void Show()
        {
            string[] names = new string[] { "Rajesh", "Ramesh", "Rakesh", "Rithish" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void Main()
        {
            ArrayStr s = new ArrayStr();
            s.Show();
        }
    }
}
