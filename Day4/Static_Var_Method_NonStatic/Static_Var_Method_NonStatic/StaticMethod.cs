using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Var_Method_NonStatic
{
    class Data
    {
        public void Show()
        {
            Console.WriteLine("Show method from class Data...");
        }
        public static void Display()
        {
            Console.WriteLine("Display method form class data..");
        }
    }
    internal class StaticMethod
    {
        static void Main()
        {
            Data.Display();
            new Data().Show();
        }
    }
}
