using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Var_Method_NonStatic
{
    static class classStatic
    {
        public static void Show()
        {
            Console.WriteLine("Show method from Class Static...");
        }
        public static string Trainer()
        {
            return "Triner is Prasanna P";
        }
    }
    internal class StaticClass
    {
        static void Main()
        {
            classStatic.Show();
            Console.WriteLine(classStatic.Trainer());
        }
    }
}
