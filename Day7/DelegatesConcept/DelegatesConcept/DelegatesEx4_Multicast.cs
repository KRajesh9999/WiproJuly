using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConcept
{
    internal class DelegatesEx4_Multicast
    {
        public delegate void DotNetFsd();

        public static void Project()
        {
            Console.WriteLine("Capstone project to be done last phasel...");
        }

        public static void MileStone1()
        {
            Console.WriteLine("MileStone 1 to be Conducted on Core Topics...");
        }

        public static void MileStone2()
        {
            Console.WriteLine("MileStone 2 to be on Dotnet Core...");
        }

        public static void MileStone3()
        {
            Console.WriteLine("MileStone 3 to be on Asp.net Core Web API");
        }

        public static void MileStone4()
        {
            Console.WriteLine("MileStone 4 to be On React Framework...");
        }

        static void Main()
        {
            DotNetFsd obj = new DotNetFsd(MileStone1);
            obj += MileStone2;
            obj += MileStone3;
            obj += MileStone4;
            obj += Project;

            obj();
        }
    }
}
