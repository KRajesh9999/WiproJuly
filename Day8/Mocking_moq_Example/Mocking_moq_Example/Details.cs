using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking_moq_Example
{
    internal class Details : IDetails
    {
        public string ShowCompany()
        {
            return "Its from Wipro Chennai.....";
        }

        public string ShowStudent()
        {
            return "Hi I am Rajesh....";
        }
    }
}
