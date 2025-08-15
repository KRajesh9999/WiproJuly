using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    [System.AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class VendorAttributes : Attribute
    {
        public string vendorName;
        public double premiumAmount;

        public VendorAttributes(string vendorName, double premiumAmount)
        {
            this.vendorName = vendorName;
            this.premiumAmount = premiumAmount;
        }
    }
}
