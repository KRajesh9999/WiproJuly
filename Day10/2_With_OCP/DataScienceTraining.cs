﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_With_OCP
{
    internal class DataScienceTraining : ITraining
    {
        public void Info()
        {
            Console.WriteLine("DataScience for Weekend...");
        }

        public void Timing()
        {
            Console.WriteLine("Timing from 9 to 6...");
        }
    }
}
