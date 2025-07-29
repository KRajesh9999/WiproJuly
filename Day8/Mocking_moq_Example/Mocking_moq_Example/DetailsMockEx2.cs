using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking_moq_Example
{
    public class DetailsMockEx2 : IDetails
    {
        public string ShowCompany()
        {
            return "Its Capgemini from Chennai...";
        }

        public string ShowStudent()
        {
            return "Hi Manali here from Capgemini...";
        }
    }
}
