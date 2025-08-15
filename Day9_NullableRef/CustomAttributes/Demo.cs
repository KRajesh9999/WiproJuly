using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    internal class Demo
    {
        public static void PrintClassInfor(Type t)
        {
            MemberInfo memberInfo = t;
            object[] arr = memberInfo.GetCustomAttributes(typeof(VendorAttributes), false);
            foreach (object ob in arr)
            {
                VendorAttributes v = (VendorAttributes)ob;
                Console.WriteLine(v.vendorName);
                Console.WriteLine(v.premiumAmount);
            }
        }
    }
}
