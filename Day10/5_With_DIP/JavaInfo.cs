using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_With_DIP
{
    internal class JavaInfo : ITrainerData
    {
        public void City()
        {
            Console.WriteLine("City is Vijag...");
        }

        public void Email()
        {
            Console.WriteLine("Email is Rubens@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Name is Rubens...");
        }
    }
}
