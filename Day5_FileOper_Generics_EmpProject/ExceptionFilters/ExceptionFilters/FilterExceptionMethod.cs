using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    internal class FilterExceptionMethod : ApplicationException
    {
        public FilterExceptionMethod(string error) : base(error) { }
    }
}
