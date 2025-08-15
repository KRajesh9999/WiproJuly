using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking_moq_Example
{
    public interface IEmployDao
    {
        List<Employ> ShowEmploy();
        Employ SearchEmploy(int empno);
    }
}
