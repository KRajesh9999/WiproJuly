using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_With_ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rajesh rajesh = new Rajesh();
            rajesh.ShowPersonalInfo();
            rajesh.ProjectName();
            rajesh.BillingInfo();

            Rakesh rakesh = new Rakesh();
            rakesh.ShowPersonalInfo();
        }
    }
}
