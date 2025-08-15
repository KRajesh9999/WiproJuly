using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Demo
    {
        public string[] names = new string[5];
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }
    internal class IndexerEx1
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo[0] = "Rajesh";
            demo[1] = "Ramesh";
            demo[2] = "Rakesh";
            demo[3] = "Rithesh";
            demo[4] = "Ragav";

            Console.WriteLine("Data is ");
            foreach(var v in  demo.names)
            {
                Console.WriteLine(v);
            }
        }
    }
}
