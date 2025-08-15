using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionLibrary;

namespace ExtensionLibraryMain
{
    internal class ExtensionLibMain
    {
        static void Main(string[] args)
        {
           Operations operations = new Operations();
            Console.WriteLine(operations.MileStone1());
            Console.WriteLine(operations.MileStone2());
            Console.WriteLine(operations.MileStone3());
            Console.WriteLine(operations.MileStone4());
            Console.WriteLine(operations.Project());
        }
    }
}
