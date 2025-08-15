using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_With_DIP
{
    internal class DotNetInfo : ITrainerData
    {
        public void City()
        {
            Console.WriteLine("City is Hyderabad...");
        }

        public void Email()
        {
            Console.WriteLine("Email is prasanna@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Name is Prasanna...");
        }
    }
}
