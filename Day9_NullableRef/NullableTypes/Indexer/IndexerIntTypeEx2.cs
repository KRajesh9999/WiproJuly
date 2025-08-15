using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class IndexerIntTypeEx2
    {
        Emp[] arr = new Emp[5];
        public Emp this[int id]
        {
            get 
            { 
                return arr[id]; 
            }
            set
            {
                arr[id] = value;
            }
        }

        static void Main()
        {
            IndexerIntTypeEx2 obj = new IndexerIntTypeEx2();
            
            obj[0] = new Emp { Empno = 1, Name = "Rajesh", Basic = 82334 };
            obj[1] = new Emp { Empno = 2, Name = "Ramesh", Basic = 82334 };
            obj[2] = new Emp { Empno = 3, Name = "Rakesh", Basic = 82334 };
            obj[3] = new Emp { Empno = 4, Name = "Ragav", Basic = 82334 };
            
            foreach(var v in obj.arr)
            {
                Console.WriteLine(v);
            }
        }
    }
}
