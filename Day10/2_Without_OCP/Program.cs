using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Without_OCP
{
    internal class Program
    {
        public static void ShowInfo(string str)
        {
            if(str == "DotNet")
            {
                DotNetTraining trg = new DotNetTraining();
                trg.Show();
                trg.Timing();
            }
            if(str == "Java")
            {
                JavaTraining trg = new JavaTraining();
                trg.Show(); 
                trg.Timing();
            }
            if(str == "Sap")
            {
                SAPTraining trg = new SAPTraining();
                trg.Show();
                trg.Timing();
            }
        }

        static void Main(string[] args)
        {
            string tinfo;
            Console.WriteLine("Enter Training (Java/DotNet/Sap) ") ;
            tinfo = Console.ReadLine();
            ShowInfo(tinfo);
        }
    }
}
