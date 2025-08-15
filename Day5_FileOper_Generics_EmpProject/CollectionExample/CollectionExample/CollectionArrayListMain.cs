using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace CollectionExample
{
    internal class CollectionArrayListMain
    {
        static void Main(string[] args)
        {
            ArrayList nameList = new ArrayList();
            nameList.Add("Rajesh");
            nameList.Add("Ramesh");
            nameList.Add("Rakesh");
            nameList.Add("Ritesh");
            nameList.Add("Rupesh");
            Console.WriteLine("Default ArrayList Elements are  ");
            foreach (object obj in nameList)
            {
                Console.WriteLine(obj);
            }

            nameList.Insert(3, "Ruthesh");
            Console.WriteLine("List after Inserting new element ");
            foreach (object obj in nameList)
            {
                Console.WriteLine(obj);
            }

            nameList.Remove("Ritesh");
            Console.WriteLine("List after Removing by name: ");
            foreach (object obj in nameList)
            {
                Console.WriteLine(obj);
            }

            nameList.RemoveAt(2);
            Console.WriteLine("List after Removing by postion: ");
            foreach (object obj in nameList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
