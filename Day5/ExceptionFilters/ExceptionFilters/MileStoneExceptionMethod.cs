using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    internal class MileStoneExceptionMethod : AggregateException
    {
        public MileStoneExceptionMethod(string error) : base(error) { }
    }
}
