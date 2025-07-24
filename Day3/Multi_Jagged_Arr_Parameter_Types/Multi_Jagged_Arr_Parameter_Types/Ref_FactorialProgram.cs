using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Jagged_Arr_Parameter_Types
{
    internal class Ref_FactorialProgram
    {
        public void Calc(int n, ref int f)
        {
            for (int i = 1; i <=n; i++)
            {
                f = f * i;
            }
        }
        static void Main()
        {
            int n, f = 1;
            Console.WriteLine("Enter n value: ");
            n = Convert.ToInt32(Console.ReadLine());
            Ref_FactorialProgram obj = new Ref_FactorialProgram();
            obj.Calc(n, ref f);
            Console.WriteLine("Factorial value: " +f);
        }
    }
}
