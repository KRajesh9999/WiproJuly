using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_With_OCP_Ex2
{
    internal class Phonepe : IElectricity
    {
        public string Payment(double billAmount)
        {
            return "Your Bill AMount is " + billAmount + " through payment PhonePe...";
        }
    }
}
