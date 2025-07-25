using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Read_Write_Auto
{
    class Vendor
    {
        int vendorId;
        string vendorName;

        public int VendorId
        {
            set { vendorId = value; }
        }

        public string VendorName
        {
            set { vendorName = value; }
        }

        public override string ToString()
        {
            return "Vendor Id " + vendorId + "Vendor name " + vendorName;
        }
    }
    internal class PropertyWriteOnly
    {
        static void Main()
        {
            Vendor vendor = new Vendor();
            vendor.VendorId = 1;
            vendor.VendorName = "Swiggy";

            Console.WriteLine(vendor);
        }
    }
}
