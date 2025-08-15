using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx1
{
    internal abstract class Training
    {
        public void Company()
        {
            Console.WriteLine("Company is Wipro...");
        }
        public abstract void Name();
        public abstract void Email();
    }
}
