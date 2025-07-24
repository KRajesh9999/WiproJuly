using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx2
{
    internal class Cow : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is Cow...");
        }

        public override void Type()
        {
            Console.WriteLine("Its Mammals Category...");
        }
    }
}
