using ExtensionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ExtensionLibrary;

namespace ExtensionLibraryMain
{
    internal static class ExtensionAddMissingData
    {
        public static string MileStone3(this Operations oper)
        {
            return "MileStone3 on .NEt core JWT web API...";
        }
        public static string MileStone4(this Operations oper)
        {
            return "MileStone 4 on REact and .Net core combination..";
        }
        public static string Project(this Operations oper)
        {
            return "Capstone Project to be Submitted Mandetorily...";
        }
    }
}
