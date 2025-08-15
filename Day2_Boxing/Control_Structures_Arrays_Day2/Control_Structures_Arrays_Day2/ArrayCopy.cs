using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Structures_Arrays_Day2
{
    internal class ArrayCopy
    {
        public void Show()

        {
            int[] a = new int[] { 12, 4, 54, 66, 33 };
            int[] b = a;
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
        static void Main()
        {
            ArrayCopy arrayCopy = new ArrayCopy();
            arrayCopy.Show();
        }
    }
}
