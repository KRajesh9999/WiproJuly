using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConcept
{
    internal class DelegateEx3_MultiCast
    {
        #region delegate_declaration
        public delegate void MyDelegate(int n);
        #endregion delegate_declaration

        #region methods
        public static void Fact(int n)
        {
            int f = 1;
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("FActorial value is "+f);
        }

        public static void PosNeg(int n)
        {
            if (n >= 0)
                Console.WriteLine("Positive number...");
            else
                Console.WriteLine("Negative number...");
        }

        public static void EvenOdd(int n)
        {
            if (n % 2 == 0)
                Console.WriteLine("Even number...");
            else
                Console.WriteLine("Odd number....");
        }
        #endregion methods

        #region Main
        static void Main()
        {
            int n;
            Console.WriteLine("Enter n value: ");
            n = Convert.ToInt32(Console.ReadLine());

            MyDelegate obj = new MyDelegate(PosNeg);
            obj += new MyDelegate(Fact);
            obj += new MyDelegate(EvenOdd);
            obj(n);
        }
        #endregion Main
    }
}
