using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace MultiThreading
{
    public class ThreadEx1
    {
        public static void OddShow()     // Thread 1
        {
            for(int i = 1; i <= 20; i += 2)
            {
                Console.WriteLine("Odd no: " + i);
                Thread.Sleep(1000);
            }
        }

        public static void EvenShow()    // Thread 2
        {
            for(int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine("Even no: " + i) ;
                Thread.Sleep(1000);
            }
        }

        public static void FactShow()   // Thread 3
        {
            int f = 1;
            for(int i = 1; i <= 10; i++)
            {
                f = f * i;
                Console.WriteLine("Factorial value: " + f);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart th1 = new ThreadStart(EvenShow);
            ThreadStart th2 = new ThreadStart(OddShow);
            ThreadStart th3 = new ThreadStart(FactShow);

            Thread t1 = new Thread(th1);
            Thread t2 = new Thread(th2);
            Thread t3 = new Thread(th3);

            t2.Start();
            t1.Start();
            t2.Join();
            t3.Start();
        }
    }
}
