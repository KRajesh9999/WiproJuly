using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_With_ISP
{
    internal class Rakesh : IPersonalDetails
    {
        public void ShowPersonalInfo()
        {
            Console.WriteLine("Hi I am Rakesh...Waiting for Project on Bench...");
        }
    }
}
