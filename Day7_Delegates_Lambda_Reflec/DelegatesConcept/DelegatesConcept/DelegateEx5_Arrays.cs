using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConcept
{
    internal class DelegateEx5_Arrays
    {
        public delegate void MyDelegate(int n);

        public static void Fact(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("FActorial value is " + f);
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

        static void Main()
        {
            Console.WriteLine("Enter N value: ");
            int n = Convert.ToInt32(Console.ReadLine());

            MyDelegate[] arr =
            {
                new MyDelegate(PosNeg),
                new MyDelegate(EvenOdd),
                new MyDelegate(Fact)
            };

            foreach(MyDelegate delgat in arr)
            {
                delgat(n);
            }
        }
    }
}
