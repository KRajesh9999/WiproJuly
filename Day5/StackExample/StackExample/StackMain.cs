using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace StackExample
{
    internal class StackMain
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Rajesh|");
            stack.Push("Ramesh|");
            stack.Push("Rakesh|");
            stack.Push("Ritesh|");
            stack.Push("Rupesh|");
            Console.WriteLine("Stack Data: ");
            Console.WriteLine("---------------------------");
            foreach (object o in stack)
            {
                Console.WriteLine(o);
                Console.WriteLine("______|");

            }
            Console.WriteLine("---------------------------");

            stack.Pop();
            Console.WriteLine("Poping one element: ");
            Console.WriteLine("---------------------------");

            foreach (object o in stack)
            {
                Console.WriteLine(o);
                Console.WriteLine("______|");
            }
            Console.WriteLine("---------------------------");

            stack.Pop();
            stack.Pop();
            Console.WriteLine("Poping two element: ");
            Console.WriteLine("---------------------------");
            foreach (object o in stack)
            {
                Console.WriteLine(o);
                Console.WriteLine("______|");

            }
            Console.WriteLine("---------------------------");
        }
    }
}
