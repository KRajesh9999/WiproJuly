using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Structures_Arrays_Day2
{
    internal class ReverseStr
    {
        static void Main()
        {
            string data;
            Console.WriteLine("Enter a String ");
            data = Console.ReadLine();
            char[] chars = data.ToCharArray();
            
            //string rev = "";
            //for (int i = chars.Length - 1; i >= 0; i--)
            //{
            //    rev += chars[i];
            //}

            Array.Reverse(chars);
            string rev = new string(chars);

            Console.WriteLine("Reversed String is: " + rev);
        }
    }
}
