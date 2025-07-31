using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples_1_WithOutSrp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ e1 = new Employ();

            e1.Empno = 1;
            e1.Name = "Rajesh";
            e1.Basic = 88787;

            e1.AddEmploy(e1);

            List<Employ> employLIst = e1.ShowEmploy();
            foreach(var v in employLIst)
            {
                Console.WriteLine(v);
            }
        }
    }
}
