﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_WithOut_DIP
{
    internal class JavaTrgInfo
    {
        private JavaTrg javaTrg;

        public JavaTrgInfo(JavaTrg javaTrg)
        {
            this.javaTrg = javaTrg;
        }

        public void Details()
        {
            javaTrg.TrainerName();
            javaTrg.City();
        }
    }
}
