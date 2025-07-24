using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// program to count the total number of vowels in a sentence

namespace Control_Structures_Arrays_Day2
{
    internal class MileStone1
    {
        public void CountVowels(string data)
        {
            data = data.ToLower(); 
            int count = 0;
            char[] chars = data.ToCharArray();
            foreach(char c in chars)
            {
                if(c == 'a' || c == 'e' || c == 'i' ||  c == 'o' || c == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine("Total no of Vowels are "+count);
        }
        static void Main()
        {
            string data;
            Console.WriteLine("Enter a string ");
            data = Console.ReadLine();
            MileStone1 obj = new MileStone1();
            obj.CountVowels(data);
        }
    }
}
