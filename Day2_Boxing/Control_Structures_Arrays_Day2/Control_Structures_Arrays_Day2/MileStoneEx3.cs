using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// Write a c# program to reverse alternate words in a given string and print. Explain in detail.
/// Sample input: welcome to dotnet programming
/// Expected output: welcome to dotnet gnimmargorp
/// </summary>

namespace Control_Structures_Arrays_Day2
{
    internal class MileStoneEx3
    {
        public string Reverse(string data)
        {
            char[] chars = data.ToCharArray();
            Array.Reverse(chars);
            //string rev = "";
            //for(int i = chars.Length - 1; i >= 0; i--)
            //{
            //    rev += chars[i];
            //}
            return new string(chars);
        }
        public void Show(string str)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if ((i % 2) != 0)
                {
                    words[i] = Reverse(words[i]);
                }
            }
            string output = string.Join(" ", words);
            Console.WriteLine("Reversed alternative words from starting sentences is: " + output);
        }
        static void Main()
        {
            string str = "Welcome to dotnet programming";
            MileStoneEx3 obj = new MileStoneEx3();
            obj.Show(str);
        }
    }
}
