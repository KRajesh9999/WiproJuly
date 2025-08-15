using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronization
{
    class Data
    {
        public void Show(string name)
        {
            lock (this)
            {
                Console.WriteLine("Hello " + name);
                Thread.Sleep(1000);
                Console.WriteLine("How are you..."); 
            }
        }
    }
    public class SyncEx1
    {
        Data data;
        SyncEx1(Data data)
        {
            this.data = data;
        }

        public void Rajesh()
        {
            data.Show("Rajesh");
        }

        public void Venkat()
        {
            data.Show("Venkat");
        }

        static void Main(string[] args)
        {
            SyncEx1 syncEx = new SyncEx1(new Data());
            ThreadStart th1 = new ThreadStart(syncEx.Rajesh);
            ThreadStart th2 = new ThreadStart(syncEx.Venkat);

            Thread t1 = new Thread(th1);
            Thread t2 = new Thread(th2);

            t1.Start(); // after Thread 1 executing T2 will join
            t2.Start();
        }
    }
}
