﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Unary
    {
        static void Main()
        {
            int x = 12;
            int y = x++ + ++x;
            Console.WriteLine("Updated value: "+y);
        }
    }
}
