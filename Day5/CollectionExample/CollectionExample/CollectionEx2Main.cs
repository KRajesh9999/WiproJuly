using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExample
{
    internal class CollectionEx2Main
    {
        static void Main()
        {
            CollectionEx2Method CollectionEx2Method1 = new CollectionEx2Method();
            CollectionEx2Method1.Empno = 1;
            CollectionEx2Method1.Name = "Rajesh";
            CollectionEx2Method1.Basic = 88233.11;

            CollectionEx2Method CollectionEx2Method2 = new CollectionEx2Method();
            CollectionEx2Method2.Empno = 2;
            CollectionEx2Method2.Name = "Sunil";
            CollectionEx2Method2.Basic = 98822.11;

            CollectionEx2Method CollectionEx2Method3 = new CollectionEx2Method();
            CollectionEx2Method3.Empno = 3;
            CollectionEx2Method3.Name = "Yamini";
            CollectionEx2Method3.Basic = 89911.11;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(CollectionEx2Method1);
            arrayList.Add(CollectionEx2Method2);
            arrayList.Add(CollectionEx2Method3);
            //arrayList.Add(12);

            foreach (object obj in arrayList)
            {
                CollectionEx2Method CollectionEx2Method = (CollectionEx2Method)obj;
                Console.WriteLine(CollectionEx2Method);
            }
        }
    }
}
