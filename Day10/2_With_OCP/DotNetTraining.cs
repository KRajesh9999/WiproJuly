﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_With_OCP
{
    internal class DotNetTraining : ITraining
    {
        public void Info()
        {
            Console.WriteLine("Dotnet FSD Training Info...");
        }

        public void Timing()
        {
            Console.WriteLine("Its from Morning 9 to 6");
        }
    }
}
