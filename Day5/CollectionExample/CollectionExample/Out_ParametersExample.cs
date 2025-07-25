using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExample
{
    internal class Out_ParametersExample
    {
        public void Show(int empno, out string name, out double basic)
        {
            name = string.Empty;
            basic = 0;
            if(empno == 1)
            {
                name = "Rajesh";
                basic = 882324.21;
            }
            if(empno == 2)
            {
                name = "Nitin";
                basic = 99321.32;
            }
            if (empno == 3)
            {
                name = "Rakesh";
                basic = 88722.11;
            }
        }
        static void Main()
        {
            int empno;
            Console.WriteLine("Enter Employ Number  ");
            empno = Convert.ToInt32(Console.ReadLine());
            Out_ParametersExample obj = new Out_ParametersExample();
            string name;
            double basic;
            obj.Show(empno, out name, out basic);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Basic is  " + basic);
        }
    }
}
