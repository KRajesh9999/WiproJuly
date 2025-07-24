using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Var_Method_NonStatic
{
    internal class StaticVar
    {
        static int count;
        public void Increment()
        {
            count++;
        }
        public void Show()
        {
            Console.WriteLine("Count " + count);
        }
        static void Main(string[] args)
        { 
                StaticVar obj1 = new StaticVar();
                StaticVar obj2 = new StaticVar();
                StaticVar obj3 = new StaticVar();

            obj1.Increment();
            obj2.Increment();
            obj3.Increment();
            obj1.Show();

            //obj1.Increment();
            //obj1.Show();
            //bj2.Increment();
            //obj2.Show();
        }
    }
}
