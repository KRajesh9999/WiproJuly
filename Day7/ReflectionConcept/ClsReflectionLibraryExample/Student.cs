using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsReflectionLibraryExample
{
    public class Student
    {
        public string name;
        public string basic;
        public int empno;

        public void ReadEmploy()
        {
            Console.WriteLine("From REadEmploy Method...");
        }

        public void WriteEmploy()
        {
            Console.WriteLine("From WriteEmploy Method...");
        }
    }
}
