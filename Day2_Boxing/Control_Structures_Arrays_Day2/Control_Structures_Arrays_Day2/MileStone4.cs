using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// program to check and print the palindromic words in a given sentence

namespace Control_Structures_Arrays_Day2
{
    internal class MileStone4
    {
        public bool IsPalindrome(string str)
        {
            str = str.ToLower();
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string rev = new string(chars);
            if(rev.Equals(str))
                return true;
            else
                return false;
        }
        public void Show(string data)
        {
            string[] words = data.Split(' ');
            foreach(string s in words)
            {
                if(IsPalindrome(s)==true)
                {
                    Console.WriteLine(s);
                }
            }
        }
        static void Main()
        {
            string data;
            Console.WriteLine("Enter a sentence with palindrom words in sentence ");
            data = Console.ReadLine();
            MileStone4 obj = new MileStone4();
            obj.Show(data);
        }

    }
}
