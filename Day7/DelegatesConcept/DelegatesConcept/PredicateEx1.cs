using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConcept
{
    internal class PredicateEx1
    {
        public static bool Check(string gender)
        {
            if(gender.Equals("Male") || gender.Equals("Female"))
                return true;
            else
                return false;
        }

        public static bool MaritialStatus(int status)
        {
            if(status == 1 || status == 0)
                return true;
            else
                return false;
        }

        static void Main()
        {
            Console.WriteLine("Enter gender(Male/Female) ") ;
            string gender = Console.ReadLine() ;
            Console.WriteLine("Enter Maritial Status: (0/1) ");
            int mstat = Convert.ToInt32(Console.ReadLine()) ;

            Predicate<string> result1 = Check;
            Console.WriteLine(result1(gender));

            Predicate<int> result2 = MaritialStatus;
            Console.WriteLine(result2(mstat)); ;
        }
    }
}
