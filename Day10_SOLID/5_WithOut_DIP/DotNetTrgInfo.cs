using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_WithOut_DIP
{
    internal class DotNetTrgInfo
    {
        private DotNetTrg dotNetTrg;

        public DotNetTrgInfo( DotNetTrg dotNetTrg )
        {
            this.dotNetTrg = dotNetTrg;
        }

        public void Details()
        {
            dotNetTrg.TrainerName();
            dotNetTrg.City();
        }
    }
}
