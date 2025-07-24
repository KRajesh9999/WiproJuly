using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx1
{
    internal class Rajesh : Training
    {
        public override void Email()
        {
            Console.WriteLine("Hi my Email is Rajesh@gmail.com");
        }
        public override void Name()
        {
            Console.WriteLine("Hi I am Rajesh...");
        }
    }
}
