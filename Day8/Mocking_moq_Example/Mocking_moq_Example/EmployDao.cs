using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking_moq_Example
{
    public class EmployDao : IEmployDao
    {
        static List<Employ> employList;

        static EmployDao()
        {
            employList = new List<Employ>()
            {
                new Employ{Empno=1,Name="Rajesh",Basic=88323},
                new Employ{Empno=2,Name="Ramesh",Basic=91911},
                new Employ{Empno=3,Name="Rakesh",Basic=86444},
                new Employ{Empno=4,Name="Rithish",Basic=89942},
                new Employ{Empno=5,Name="Raghav",Basic=88932},
                new Employ{Empno=6,Name="Ruthivk",Basic=81323},
            };
        }

        public Employ SearchEmploy(int empno)
        {
            Employ employFound = null;
            foreach(Employ employ in employList)
            {
                if (employ.Empno == empno)
                    employFound = employ;
            }
            return employFound;
        }

        public List<Employ> ShowEmploy()
        {
            return employList;
        }
    }
}
