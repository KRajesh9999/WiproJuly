using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_concepts
{
    class First
    {
        public void Show()
        {
            Console.WriteLine("Show method from class First(Base Class)...");
        }
    }
    class Second : First
    {
        public void Display()
        {
            Console.WriteLine("Display method from Class second - (Derived Class)...");
        }
    }
    internal class InheritanceEx
    {
        static void Main()
        {
            Second second = new Second();
            second.Show();
            second.Display();
        }
    }
}
