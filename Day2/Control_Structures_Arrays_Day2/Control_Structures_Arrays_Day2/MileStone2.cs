using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// programe to split the words

namespace Control_Structures_Arrays_Day2
{
    internal class MileStone2
    {
        static void Main()
        {
            string str = "Welcome to dotnet programming trainer Prasanna";
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
