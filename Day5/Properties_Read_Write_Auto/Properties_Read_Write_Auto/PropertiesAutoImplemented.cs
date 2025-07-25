using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Read_Write_Auto
{
    class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }
    }
    internal class PropertiesAutoImplemented
    {
        static void Main()
        {
            Employ emp1 = new Employ();
            emp1.Empno = 1;
            emp1.Name = "Rajesh";
            emp1.Basic = 98776.32;
            
            Employ emp2 = new Employ();
            emp2.Empno = 2;
            emp2.Name = "Rakesh";
            emp2.Basic = 88776.32;

            Employ emp3 = new Employ();
            emp3.Empno = 3;
            emp3.Name = "Ramesh";
            emp3.Basic = 90776.32;

            Console.WriteLine("First Employee Record(s)  ");
            Console.WriteLine("Employ No  " + emp1.Empno + " Employ Name " + emp1.Name + " Employ Basic  " + emp1.Basic);
            Console.WriteLine("Employ No  " + emp2.Empno + " Employ Name " + emp2.Name + " Employ Basic  " + emp2.Basic);
            Console.WriteLine("Employ No  " + emp3.Empno + " Employ Name " + emp3.Name + " Employ Basic  " + emp3.Basic);
        }
    }
}
