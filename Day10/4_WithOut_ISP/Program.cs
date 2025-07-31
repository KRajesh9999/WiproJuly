using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_WithOut_ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployDetails employDetails = new Rajesh();
            employDetails.PersonalDetails();
            employDetails.ProjectDetails();
            employDetails.AccountDetails();
        }
    }
}
