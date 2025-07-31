using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_With_OCP_Ex2
{
    internal interface IElectricity
    {
        string Payment(double billAmount);
    }
}
