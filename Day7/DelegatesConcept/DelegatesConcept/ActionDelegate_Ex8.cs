﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConcept
{
    internal class ActionDelegate_Ex8
    {
        public static void Greeting(string s)
        {
            Console.WriteLine("Good morning..."+s);
        }

        public static void EndNote(string s)
        {
            Console.WriteLine("Good Night..."+s);
        }

        static void Main()
        {
            string str;
            Console.WriteLine("Enter name: ") ;
            str = Console.ReadLine();
            Action<string> obj = Greeting;
            obj += EndNote;
            obj(str);
        }
    }
}
